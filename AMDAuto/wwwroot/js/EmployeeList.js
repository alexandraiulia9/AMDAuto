$(document).ready(function () {
    var pageNumber = 1;
    var source = $("#employees-template").html();
    var template = Handlebars.compile(source);

    $('#loadMoreButton').on('click', function () {
        pageNumber++;
        $.get(Router.action("Admin", "GetEmployees", { page: pageNumber }))
            .done(manageEmployees)
            .fail(function () {
                alert("Eroare!");
            });
        function manageEmployees(result) {
            for (let i = 0; i < result.employeeList.length; i++) {
                var employeeId = result.employeeList[i].id;
                var employeeName = result.employeeList[i].name;

                var context = { employeeId: employeeId, employeeName: employeeName };
                var html = template(context);
                $('#EmployeeList').append(html);
            }

            if (result.isLastPage == true) {
                $('#loadMoreButton').hide();
            }
        }
    });
});