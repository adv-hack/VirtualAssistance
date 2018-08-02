<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/Main.Master" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="Consensus.Web.BackOffice.SearchPage" %>
<asp:Content runat="server" ContentPlaceHolderID="PageButtons">
  <div class="float-left">
      <asp:Button runat="server" ID="CreateButton" CssClass="btn btn-success float-right ml-3" Text="Create new" />
      </div>
    </asp:Content>
<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="alert alert-danger mb-4" style="display: none">
      There are errors on this page.  Please correct these errors and retry.
    </div>
    <asp:Panel runat="server" ID="SearchCriteriaPanel" CssClass="panel panel-default pb-3 pl-3 pr-3" DefaultButton="SearchButton">
      <div runat="server" id="SearchCriteria">
      </div>
      <div class="clearfix mt-3">
        <asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary float-right ml-3" Text="Search" OnClick="SearchButton_Click" OnClientClick="return validateSearch();" />
        <asp:Button runat="server" ID="ResetButton" CssClass="btn btn-warning float-right ml-3" Text="Reset" OnClick="ResetButton_Click" />
      </div>
    </asp:Panel>
    <con:DataTable runat="server" ID="SearchResult" CanModify="false" CanCreate="false" PageSize="0" />
    <style> .dataTables_wrapper { padding: 0 !important; }</style>
    <script>
        function validateSearch() {
            var validation = consensus.data.validation.check();
            var success = (validation.formErrors == 0 && validation.pageErrors == 0);
            if (!success)
                $('.alert').slideDown(250).delay(5000).slideUp(500);

            return success;
        }

        function setNextProfileField(profileIx, listID, nextObj, hidSearchFieldID, hidExtraWhereID, hidLevel2ExistsID, hidLevel3ExistsID) {

            var thisList = $("#" + listID + "Field");
            var nextExists = ((profileIx == 0 && thisList.val()) || thisList.find("option").eq(thisList.prop("selectedIndex")).attr("data-next-exists") == "1");
            var typeList = (profileIx == 0 ? thisList : $("#" + listID.substr(0, listID.length - 1) + "0Field"));

            if (nextExists) {
                nextObj._fieldElement.prop("disabled", false);
                if (nextObj._populator) {
                    var type = null, xtraWhere = null, level1 = null, level2 = null;

                    type = typeList.val();
                    xtraWhere = typeList.find("option").eq(typeList.prop("selectedIndex")).attr("data-extra-where");
                    if (profileIx == 1)
                        level1 = thisList.val();
                    else if (profileIx == 2) {
                        level1 = $("#" + listID.substr(0, listID.length - 1) + "1Field").val();
                        level2 = thisList.val();
                    }

                    var parameters = [];
                    parameters.push({ name: "@PA_PROFILE_TYPE", value: type });
                    parameters.push({ name: "@PA_EXTRA_WHERE", value: xtraWhere });
                    parameters.push({ name: "@PA_LEVEL_1", value: level1 });
                    parameters.push({ name: "@PA_LEVEL_2", value: level2 });
                    nextObj._populator.setParameters(parameters);
                }
            }
            else {
                nextObj._fieldElement
                    .prop("disabled", true)
                    .find('option').remove();
            }
                       

            // Reset any levels beyond the next one.
            if (profileIx <= 1) { 
                if (profileIx == 0) {
                    $("#" + listID.substr(0, listID.length - 1) + "2Field")
                        .prop("disabled", true)
                        .find('option').remove();
                }
                $("#" + listID.substr(0, listID.length - 1) + "3Field")
                    .prop("disabled", true)
                    .find('option').remove();
            }

            // If we are setting level 0, save the search field name for the selected profile type
            if (profileIx == 0)
            {
                var selectedOption = thisList.find("option").eq(thisList.prop("selectedIndex"));
                $("#" + hidSearchFieldID).val(selectedOption.attr("data-search-field"));
                $("#" + hidExtraWhereID).val(selectedOption.attr("data-extra-where"));                
            }
            else if (profileIx < 3)
            {
                $("#" + (profileIx == 1 ? hidLevel2ExistsID : hidLevel3ExistsID)).val(nextExists ? "1" : "0");
            }
        }

    </script>
</asp:Content>
