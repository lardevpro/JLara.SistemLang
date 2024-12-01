$(function () {

    $("#ProgresFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#ProgresCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#ProgresFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/ProgresFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('JLaraSystemLeng');

    var service = jLaraSystemLeng.progress.progres;
    var createModal = new abp.ModalManager(abp.appPath + 'Progress/Progres/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Progress/Progres/EditModal');

    var dataTable = $('#ProgresTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('JLaraSystemLeng.Progres.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('JLaraSystemLeng.Progres.Delete'),
                                confirmMessage: function (data) {
                                    return l('ProgresDeletionConfirmationMessage', data.record.id);
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
                title: l('ProgresUserId'),
                data: "userId"
            },
            {
                title: l('ProgresPracticeDate'),
                data: "practiceDate"
            },
            {
                title: l('ProgresPronunciationAccuracy'),
                data: "pronunciationAccuracy"
            },
            {
                title: l('ProgresRecommendation'),
                data: "recommendation"
            },
            {
                title: l('ProgresDifficultyLevel'),
                data: "difficultyLevel"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewProgresButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
