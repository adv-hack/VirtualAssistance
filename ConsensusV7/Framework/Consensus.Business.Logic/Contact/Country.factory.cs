using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CountryModel" /> object.
    /// </summary>
    public partial class LocalCountryFactory
    {

        /// <summary>
        /// Checks if Country's name or code exist
        /// </summary>
        /// <param name="name">Name of the country</param>
        /// <param name="code">Code of the country</param>
        /// <param name="countryId">Id of the country</param>
        /// <returns>Whether country's name or code exist in database</returns>
        public object CheckIfCountryOrCodeExist(System.String name, System.String code, System.String countryId)
        {
            var countries = this.FetchAll();
            var codeList = countries.Where(x => x.CountryCode != null && x.CountryCode.Trim().ToLower() == code.Trim().ToLower()).ToList();
            var nameList = countries.Where(x => x.Name != null && x.Name.Trim().ToLower() == name.Trim().ToLower()).ToList();

            if (nameList.Count > 0 || codeList.Count > 0)
            {
                if (string.IsNullOrEmpty(countryId))
                {
                    if (nameList.Count > 0 && codeList.Count > 0)
                    {
                        return new { name = true, code = true };
                    }
                    else if (nameList.Count > 0)
                    {
                        return new { name = true, code = false };
                    }
                    else
                    {
                        return new { name = false, code = true };
                    }
                }
                else
                {
                    var nameExist = false;
                    var codeExist = false;

                    if (nameList.Count > 0 && nameList.Any(x => x.Id == countryId))
                    {
                        nameExist = false;
                    }
                    else
                    {
                        if (nameList.Count > 0)
                            nameExist = true;
                    }

                    if (codeList.Count > 0 && codeList.Any(x => x.Id == countryId))
                    {
                        codeExist = false;
                    }
                    else
                    {
                        if (codeList.Count > 0)
                            codeExist = true;
                    }

                    return new { name = nameExist, code = codeExist };
                }
            }
            else
            {
                return new { name = false, code = false };
            }
        }

    }
}

