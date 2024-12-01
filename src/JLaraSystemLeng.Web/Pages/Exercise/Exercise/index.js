$(function () {

    $("#ExerciseFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#ExerciseCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#ExerciseFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/ExerciseFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('JLaraSystemLeng');

    var service = jLaraSystemLeng.exercise.exercise;
    var createModal = new abp.ModalManager(abp.appPath + 'Exercise/Exercise/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Exercise/Exercise/EditModal');

    var dataTable = $('#ExerciseTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('JLaraSystemLeng.Exercise.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('JLaraSystemLeng.Exercise.Delete'),
                                confirmMessage: function (data) {
                                    return l('ExerciseDeletionConfirmationMessage', data.record.id);
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
                title: l('ExerciseUserId'),
                data: "userId"
            },
            {
                title: l('ExercisePhrase'),
                data: "phrase"
            },
            {
                title: l('ExerciseDifficultyLevel'),
                data: "difficultyLevel"
            },
            {
                title: l('ExerciseFocusArea'),
                data: "focusArea"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewExerciseButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
