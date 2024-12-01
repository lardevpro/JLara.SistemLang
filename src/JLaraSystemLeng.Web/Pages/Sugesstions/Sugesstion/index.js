$(function () {

    $("#SugesstionFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#SugesstionCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#SugesstionFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/SugesstionFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('JLaraSystemLeng');

    var service = jLaraSystemLeng.sugesstions.sugesstion;
    var createModal = new abp.ModalManager(abp.appPath + 'Sugesstions/Sugesstion/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Sugesstions/Sugesstion/EditModal');

    var dataTable = $('#SugesstionTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,//disable default searchbox
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList,getFilter),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('JLaraSystemLeng.Sugesstion.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('JLaraSystemLeng.Sugesstion.Delete'),
                                confirmMessage: function (data) {
                                    return l('SugesstionDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('SugesstionUserId'),
                data: "userId"
            },
            {
                title: l('SugesstionSugesstionText'),
                data: "sugesstionText"
            },
            {
                title: l('SugesstionSugesstionCreationDate'),
                data: "sugesstionCreationDate"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewSugesstionButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
