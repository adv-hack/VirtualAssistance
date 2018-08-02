<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.crm.popups.PersonSearch" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Person Search" %>

<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
    <div class="row">
        <div class="col-sm-2">
            <con:TextField runat="server" ID="PersonID" LabelText="Person ID" IsEditable="true" ValueUrlParameter="personID" ValueUrlIsEnforced="false" />
        </div>
        <div class="col-sm-2">
            <con:TextField runat="server" ID="FirstName" LabelText="First Name" IsEditable="true" ValueUrlParameter="personFirstName" ValueUrlIsEnforced="false" />
        </div>
        <div class="col-sm-2">
            <con:TextField runat="server" ID="Surname" LabelText="Surname" IsEditable="true" ValueUrlParameter="personSurname" ValueUrlIsEnforced="false" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="Organisation" LabelText="Organisation" IsEditable="true" ValueUrlParameter="orgText" ValueUrlIsEnforced="false" />
        </div>
        <div class="col-sm-2">
            <con:TextField runat="server" ID="Postcode" LabelText="Postcode" IsEditable="true" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-3">
            <con:TextField runat="server" ID="Email" LabelText="Email" IsEditable="true" />
        </div>
        <div class="col-sm-2">
            <con:CodeField runat="server" ID="RoleType" LabelText="Role Type" CodeType="ROLE" IsEditable="true" />
        </div>
        <div class="col-sm-2">
            <con:CodeField runat="server" ID="JobType" LabelText="Job Type" CodeType="ROLET" IsEditable="true" />
        </div>
        <div class="col-sm-2">
            <con:TextField runat="server" ID="SysRef" LabelText="Person Ref" IsEditable="true" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2">
            <con:ListField runat="server" ID="PersonProfiles" IsHidden="TrueEnforced" DisplayMember="Key" ValueMember="Values" />
            <con:ListField runat="server" ID="AssociateProfiles" IsHidden="TrueEnforced" DisplayMember="Key" ValueMember="Values" />
            <con:ListField runat="server" ID="VolunteerProfiles" IsHidden="TrueEnforced" DisplayMember="Key" ValueMember="Values" />

            <con:ListField runat="server" ID="ProfType" LabelText="Profile" IsEditable="true" ClientOnChange="CheckProfileType(this)">
                <Items>
                    <asp:ListItem Text="" Value="-1" />
                  <asp:ListItem Text="Person" Value="" />
                  <asp:ListItem Text="Associate" Value="0" />
                  <asp:ListItem Text="Volunteer" Value="1" />
                </Items>
            </con:ListField>
        </div>
        <div class="col-sm-2">
            <con:ListField runat="server" ID="Level1" LabelText="Level 1" IsEditable="true" IsReadOnly="True" ClientOnChange="SetLevel2Values()" >
               
            </con:ListField>
        </div>
        <div class="col-sm-2">
            <con:ListField runat="server" ID="Level2" LabelText="Level 2" IsEditable="true" IsReadOnly="True" ClientOnChange="SetLevel3Values()" >
                
                </con:ListField>
        </div>
        <div class="col-sm-2">
            <con:ListField runat="server" ID="Level3" LabelText="Level 3" IsEditable="true" IsReadOnly="True" >
                
                </con:ListField>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2">
            <con:CodeField runat="server" ID="AssociateStatus" LabelText="Associate status" CodeType="TRSTA" IsEditable="true" />
        </div>
        <div class="col-sm-2">
            <con:CodeField runat="server" ID="AssociateType" LabelText="Associate type" CodeType="TRAN1" IsEditable="true" />
        </div>
        <div class="col-sm-2">
            <con:CodeField runat="server" ID="VolunteerStatus" LabelText="Volunteer status" CodeType="VRSTA" IsEditable="true" />
        </div>
        <div class="col-sm-2">
            <con:CodeField runat="server" ID="VolunteerType" LabelText="Volunteer type" CodeType="VRAN1" IsEditable="true" />
        </div>
        <div class="col-sm-1">
            <asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" Style="margin-top: 37px" OnClick="SearchButton_Click" />
        </div>
        <div>
            <con:HiddenField runat="server" ID="personType" ValueUrlParameter="personType" ValueUrlIsEnforced="true" />
        </div>
    </div>
    
</asp:Content>

<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
    <con:DataTable runat="server" ID="SearchResult" PageLength="10" CanCreate="true" CanCreateInEditMode="true" CanModify="false" Url="~/GenericPopup.aspx?context=crm&control=newpersondetail">
        <Columns>
            <con:DataTableTextColumn FieldName="PN_ID" Title="Person ID" />
            <con:DataTableTextColumn FieldName="PROLE_ID" Title="Role ID" />
            <con:DataTableTextColumn FieldName="PN_FIRST_NAME" Title="First Name" />
            <con:DataTableTextColumn FieldName="PN_SURNAME" Title="Surame" />
            <con:DataTableTextColumn FieldName="PROLE_ORG_NAME" Title="Organisation" />
            <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{PROLE_PN_NAME}}', value: '{{PROLE_ID}}', data: {salutation: '{{PN_SALUTATION}}', organisation: { id: '{{PROLE_ORG_ID}}', name: '{{PROLE_ORG_NAME}}' }, address: { id: '{{ADD_ID}}', mailstring: '{{ADD_MAILSTRING}}', Line1: '{{ADD_BUILDING}}', Line2: '{{ADD_STREET}}', Line3: '{{ADD_AREA}}', town: '{{ADD_TOWN}}', county: '{{ADD_COUNTY}}', postcode: '{{ADD_POSTCODE}}', country: '{{ADD_COUNTRY}}'  }, telephone: '{{PROLE_PHONE}}', fax: '{{PROLE_FAX}}', email: '{{PROLE_EMAIL}}', pnId: '{{PN_ID}}' } });" LinkText="Select" />
        </Columns>
    </con:DataTable>
    <%--<script type="text/javascript">

        $(document).ready(function () {
            if ($('[id$=_SearchResult_wrapper] a.btn-success.consensus-visible-read').hasClass('consensus-visible-read')) {
                $('[id$=_SearchResult_wrapper] a.btn-success.consensus-visible-read').removeClass('consensus-visible-read');
            }
        });

    </script>--%>

    <script type="text/javascript">
        var newArray = [], val1, val2;
        var level1 = $('#<%= this.Level1.ClientID %>Field');
            var level2 = $('#<%= this.Level2.ClientID %>Field');
            var level3 = $('#<%= this.Level3.ClientID %>Field');

        function CheckProfileType(control)
        {
            newArray = [];
            var flagType = document.getElementById("<%= this.ProfType.ClientID %>Field").options[control.selectedIndex].innerHTML;
            var selVale = control.value;
            var profilesControl, profileType;
            //if(!flagType && selVale=='-1')
            //{
                EmptyDropDown(level1[0]); EmptyDropDown(level2[0]); EmptyDropDown(level3[0]);
                newArray = [];
                level1.attr('readonly', 'readonly').attr('disabled', 'disabled');
                level2.attr('readonly', 'readonly').attr('disabled', 'disabled');
                level3.attr('readonly', 'readonly').attr('disabled', 'disabled');
                
            //}
             if (flagType == 'Person')
            {
                //profileType = 'Person';
                profilesControl = document.getElementById("<%= this.PersonProfiles.ClientID %>Field").options;
                SetValues(flagType, profilesControl);
            }
            else if (flagType == 'Associate') {
                profilesControl = document.getElementById("<%= this.AssociateProfiles.ClientID %>Field").options;
                SetValues(flagType, profilesControl);
            }
            else if (flagType == 'Volunteer') {
                profilesControl = document.getElementById("<%= this.VolunteerProfiles.ClientID %>Field").options;
                SetValues(flagType, profilesControl);
            }
            
        }
        function SetValues(prof_type, profilesControl) {
            //var profilesControl = document.getElementById("<%--<%= this.profilesControl.ClientID %>F--%>ield").options;
            // loop in profilesControl
            for (var i = 0; i < profilesControl.length; i++) {
                //if (profilesControl[i].text) {
                // check if the key already exists, if not then push in the new Array of obj
                if (newArray.filter(e => e.Key === profilesControl[i].text).length == 0) {

                    newArray.push({
                        "Key": profilesControl[i].text,
                        "Value": []
                    });
                }
                else {
                    // find the index of the first key added in the array and their Values (Value1 and Value 2)
                    var index = newArray.findIndex(e => e.Key === profilesControl[i].text);
                    val1 = profilesControl[i].value.split("Value1 = ")[1].split(",")[0].trim();
                    val2 = profilesControl[i].value.split("Value2 = ")[1].split(",")[0].split("}")[0].trim();

                    if (val1) {
                        //check if the value1 already exists, add in the ParentKey's Index, if not
                        if (newArray[index].Value.filter(e => e.Key === val1).length == 0)//not exists 
                        {
                            var InnerValue = [];
                            if (val2) {
                                if (InnerValue.length == 0) InnerValue.push("");
                                InnerValue.push(val2); // Add Value2 for new Value1, if found
                            }
                            if (newArray[index].Value.length == 0) {
                                newArray[index].Value.push({
                                    "Key": "",
                                    "Value": []
                                });
                            }
                            //push values in the parentKey's index 
                            newArray[index].Value.push({
                                "Key": val1,
                                "Value": InnerValue
                            });

                        }
                        else {
                            var innerKey = newArray[index].Value.findIndex(e => e.Key == val1);
                            
                            if (val2) {
                                
                                newArray[index].Value[innerKey].Value.push(val2);
                            }
                        }

                    }
                }
            } // End of Loop

            //Bind Level1/Value1 dropdowns by looping in new ArrayOfObject
            $.each(newArray, function (key, value) {
                level1
                    .append($("<option></option>")
                               .attr("value", key)
                               .text(value.Key));
            });
            if (level1[0].length > 0)
                level1.attr('readonly', null).attr('disabled', null);
        }// End of function
        
        function SetLevel2Values()
        {
            var selectedKey = level1[0].options[level1[0].selectedIndex].innerHTML;
            var selectedIndex = level1[0].selectedIndex;
            var array = newArray[selectedIndex];
            if (newArray[selectedIndex].Value.length > 0) {
                $.each(newArray[selectedIndex].Value, function (Key1, Value1) {
                    level2
                    .append($("<option></option>")
                               .attr("value", Key1)
                               .text(Value1.Key));
                });
                if (level2[0].length > 0)
                    level2.attr('readonly', null).attr('disabled', null);
            }
            else {
                EmptyDropDown(level2[0]);
                level2.attr('readonly', 'readonly').attr('disabled', 'disabled');
                
            }
        }

        function SetLevel3Values()
        {
            var selectedKey = level2[0].options[level2[0].selectedIndex].innerHTML;
            var selectedIndex_Level1 = level1[0].selectedIndex;
            if (newArray[selectedIndex_Level1].Value[level2[0].selectedIndex].Value.length > 0) {
                $.each(newArray[selectedIndex_Level1].Value[level2[0].selectedIndex].Value, function (Key1, Value1) {
                    level3
                    .append($("<option></option>")
                               .attr("value", Key1)
                               .text(Value1));
                });
                if (level3[0].length > 0)
                    level3.attr('readonly', null).attr('disabled', null);
            }
            else {
                EmptyDropDown(level3[0]);
                level3.attr('readonly', 'readonly').attr('disabled', 'disabled');

            }
        }
         
        function EmptyDropDown(control)
        {
            if (control)
                control.options.length = 0;
            
        }
        
        

        
    </script>
</asp:Content>
