using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.Routing;
using System.Web.Script.Serialization;
using System.IO;
using System.Collections;
using System.Web.SessionState;
using Consensus.Security;

namespace Consensus.Web
{
    class FileHandler : ElementHandler
    {
        public FileHandler(RouteValueDictionary routingData) : base(routingData) { }

        protected override void HandleRequest(HttpContext httpContext)
        {
            // Identify the logic required to respond to the request.
            switch (httpContext.Request.HttpMethod.ToUpper())
            {
                case "GET": this.ProcessGetRequest(httpContext); break;
                case "POST": this.ProcessPostRequest(httpContext); break; // Unlike a rest call, POST means insert a new item. There is no update action.
                default: this.ProcessResponse(405, "Method Not Supported"); break;
            }
        }

        /// <summary>
        ///     Processes a HTTP POST request for uploading a file from fine-uploader.
        /// </summary>
        private void ProcessPostRequest(HttpContext httpContext)
        {
            ReturnStruct status = new ReturnStruct();
            status.success = true;

            try
            {

                if (httpContext.Request.Files.Count > 0)
                {
                    HttpPostedFile file = httpContext.Request.Files[0];
                    status.name = Path.GetFileName(file.FileName);
                    status.uuid = httpContext.Request["qquuid"];
                    status.size = file.ContentLength;
                    
                    byte[] bte = new byte[file.InputStream.Length];

                    file.InputStream.Read(bte, 0, Convert.ToInt32(file.InputStream.Length));

                    if (this.RestContext.Equals("common", StringComparison.InvariantCultureIgnoreCase) && this.RestElement.Equals("attachmentdata", StringComparison.InvariantCultureIgnoreCase))
                    {
                        status.DataId = SaveAttachmentData(httpContext, file, status.name, bte);
                    }
                    else
                    {
                        throw new ApplicationException(string.Format("There is no implementation for uploading files to httpContext '{0}', element '{1}'", this.RestContext, this.RestElement));
                    }
                }
            }
            catch (Exception ex)
            {
                status.error = ex.Message;
                status.preventRetry = true;
                status.success = false;
            }

            this.ProcessResponse(status);
        }

        private string SaveAttachmentData(HttpContext httpContext, HttpPostedFile file, string fileName, byte[] bte)
        {
            Common.Attachment attachment = Common.Attachment.Create();

            attachment.FileName = fileName;
            attachment.Mime = file.ContentType;

            attachment.TableUrl = httpContext.Request["tableURL"];
            attachment.RecordId = httpContext.Request["recordId"];
            attachment.Web = 1;

            Common.AttachmentData attachmentData = Common.AttachmentData.Create();
            attachmentData.Binary = bte;
            attachmentData.VersionNo = 0.0;

            attachment.DataAttachments.Add(attachmentData);
            
            attachment.Save();
                        
            return attachment.Id;
        }


        public class ReturnStruct
        {
            public bool success { get; set; }
            public string error { get; set; }
            public bool preventRetry { get; set; } // prevent Fine Uploader from making any further attempts to retry uploading the file
            // public bool reset { get; set; } // restart with the first chunk on the next attempt. Only applies if chunking is enabled (which it isn't, currently)
            public string uuid { get; set; }
            public string name { get; set; }
            public int size { get; set; }
            public string DataId { get; set; }
        }


        private void ProcessGetRequest(HttpContext httpContext)
        {
            try
            {
                FileDataPackage data;
                if (this.RestContext.Equals("common", StringComparison.InvariantCultureIgnoreCase) && this.RestElement.Equals("attachmentdata", StringComparison.InvariantCultureIgnoreCase))
                {
                    data = GetAttachmentData(this.RestObject);
                }
                else
                {
                    throw new ApplicationException(string.Format("There is no implementation for uploading files to httpContext '{0}', element '{1}'", this.RestContext, this.RestElement));
                }
                bool bInline = false;

                httpContext.Response.ContentType = data.MimeType;
                //byte[] byt = data.FileData;
                //FileInfo f = null;

                if (!String.IsNullOrEmpty(data.FileName))
                {
                    //f = new FileInfo(data.FileName);
                    httpContext.Response.AddHeader("content-disposition", (bInline ? "inline" : "attachment") + ";filename=" + data.FileName /*f.Name*/);
                }

                //if (iScaleTo > 0)
                //    byt = scaleImage(byt, f, iScaleTo, oDownload);

                // Should be more efficient if we do not compress small files
                //if (httpContext.Response.Headers["Content-encoding"] != null
                //    && byt.Length < 4096)
                //{
                //    httpContext.Response.Headers.Remove("Content-encoding");
                //    httpContext.Response.Filter = null;
                //}

                httpContext.Response.BinaryWrite(data.FileData /*byt*/);
            }
            catch (Exception ex)
            {
                httpContext.Response.ContentType = "text/plain";
                httpContext.Response.Output.WriteLine(ex.Message);
            }
        }

        private FileDataPackage GetAttachmentData(string Id)
        {
            FileDataPackage pkg = new FileDataPackage();

            Common.Attachment attachment = Common.Attachment.FetchById(Id);

            if (attachment == null || attachment.DataAttachments.Count == 0)
                throw new ApplicationException("No attachment found with this ID (" + Id + ")");

            pkg.MimeType = attachment.Mime;
            pkg.FileName = attachment.FileName;
            pkg.FileData = attachment.DataAttachments[0].Binary;

            return pkg;
        }

        public class FileDataPackage
        {
            public string MimeType { get; set; }
            public byte[] FileData { get; set; }
            public string FileName { get; set; }
        }
    }
}
