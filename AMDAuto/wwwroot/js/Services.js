$('#CategoryId').on("change", function () {
    var categoryId = $('#CategoryId').val();
    $.get(Router.action("Operations", "GetOperationByCategoryId"), { categoryId: categoryId })
        .done(manageOperations)
        .fail(function () {
            alert("Eroare!");
        });
})

function manageOperations(result) {
    var tr = '';
    var td1 = '';
   
    $('#OperationsTBody').empty();

    tr += '<tr>'; 
    for (let i = 0; i < result.length; i++) {
       
        td1 += '<td>' + result[i].name + '</td>' + '<td>' + result[i].duration + " min" + '</td>' + '<td>' + result[i].price + " lei" + '</td> </tr>';  
    }
    tr += td1;
    $('#OperationsTBody').append(tr);
 

}