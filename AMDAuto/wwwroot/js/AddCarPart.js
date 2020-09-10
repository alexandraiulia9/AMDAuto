$('#CategoryId').on("change", function () {
    var categoryId = $('#CategoryId').val();
    $.get(Router.action("Operations", "GetOperationByCategoryId"), { categoryId: categoryId })
        .done(manageOperations)
        .fail(function () {
            alert("Eroare!");
        });
})

function manageOperations(result) {
    var options = '';

    $('#OperationsDropDown').empty();

    for (let i = 0; i < result.length; i++) {
        options += '<option value= "' + result[i].id + '">' + result[i].name + '</option>';
    }

    $('#OperationsDropDown').append(options);
}