<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Comments.ascx.cs" Inherits="Consensus.Web.BackOffice.common.controls.Comments" %>
<div id="conFootComments" class="con-foot-comments container-fluid">
    <div class="row">
      <div class="col-xs-12">
          <div class="btn-group">
              <a class="btn btn-default btn-success consensus-visible-read mr-2 con-comments-tbb-add" tabindex="0" href="#">
                  <span>Add</span>
              </a>
              <a class="btn btn-default btn-outline-secondary con-comments-tbb-show" tabindex="0" href="#">
                  <%--<i class="icons8-collapse_arrow" />--%>
                  <span>Expand all</span>
              </a>
              <a class="btn btn-default btn-outline-secondary con-comments-tbb-text" tabindex="0" href="#"> 
                  <span>Plain text</span>
              </a>
          </div>
      </div>
    </div>
    <div id="footComments" class="con-comments">
    </div>
</div>

<script type="text/template" id="conCommentsTemplate">
    <div class="con-comment">
        <div class="row con-comments-modified">
          <div class="col-xs-12">
              <label>Created by</label><span class="con-comments-created-user"></span><label>on</label><span class="con-comments-created-date"></span><label>at</label><span class="con-comments-created-time"></span>
              <span  class="con-comments-edited hidden">
                  (<label>Edited by</label><span class="con-comments-edited-user"></span><label>on</label><span class="con-comments-edited-date"></span><label>at</label><span class="con-comments-edited-time"></span>)
              </span>
          </div>
        </div>
        <div class="row">
            <div class="col-xs-12">
                <div class="con-comments-container con-comments-limited">
                    <div class="con-comments-html"/>
                    <div class="con-comments-text hidden"/>
                    <div class="btn btn-link con-comments-btn con-comments-edit" title="Edit comment">
                        <i class="icons8-edit_row" />
                    </div>
                    <div class="btn btn-link con-comments-btn con-comments-expand" title="Show all of the comment">
                        <i class="icons8-expand_arrow" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</script>

<script type="text/javascript">
    var footComments = new consensus.web.comments($("#conFootComments"), $("#conCommentsTemplate"), $("#footComments"),
        "<%=AttachmentParentURL%>", "<%=AttachmentParentId%>", <%=CanEdit%>, <%=UserId%>);
</script>