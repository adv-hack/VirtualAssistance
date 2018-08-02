<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProfileTree.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.ProfileTree" %>

            <div style="height:350px;overflow:scroll;overflow-x:hidden;">
                <div id="profilesJSTree"></div>
            </div>

<script type="text/javascript">

    $(document).ready(function () {
        LoadProfileTree();
        window.save = function () {
            var nodes = $('#profilesJSTree').jstree('get_selected', true);
            if (nodes.length == 1)
                SelectNode(nodes[0]);
        }
    });

    function SelectNode(node) {
        var key = stripPrefix(node.parents.length == 1 ? node.text : node.parents.length == 2 ? node.parents[0] : node.parents[1], '#');
        var level1 = stripPrefix(node.parents.length == 1 ? '' : node.parents.length == 2 ? node.text : node.parents[0], '#');
        var level2 = stripPrefix(node.parents.length == 1 ? '' : node.parents.length == 2 ? '' : node.text, '#');
        closePopup({ command: 'select', fireOnChange: true, value: key, text: key, data: { level1: level1, level2: level2 } });
    }

    function stripPrefix(value, prefix) {
        while (value && value.length > 1 && value[0] == prefix)
            value = value.substr(1);
        return value;
    }

    function LoadProfileTree() {
        $('#profilesJSTree').jstree({
            "core": {
                "themes": {
                    "icons": false
                },
                'check_callback': true,
                "data": {
                    type: "POST",
                    url: "rest/common/code/fetchAllInTree?codeType=<%= this.Request.QueryString["profileType"] %>",
                    contentType: "application/json; charset=utf-8"
                }
            },
        });
        $('#profilesJSTree').on('dblclick', '.jstree-anchor', function (e) {
            var instance = $.jstree.reference(this),
            node = instance.get_node(this);
            SelectNode(node);
        });        
    }

</script>