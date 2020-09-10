$(document).ready(function () {
    var pageNumber = 1;
    var source = $("#users-template").html();
    var template = Handlebars.compile(source);

    $('#loadMoreButton').on('click', function () {
        pageNumber++;
        $.get(Router.action("Employee", "GetUsers", { page: pageNumber }))
            .done(manageUsers)
            .fail(function () {
                alert("an error has occured");
            });

       function manageUsers(result){
            for (let i = 0; i < result.userList.length; i++) {
                var userId = result.userList[i].id;
                var userName = result.userList[i].name;

                var context = { userId: userId, userName: userName };
                var html = template(context);
                $('#UserList').append(html);
            }

            if (result.isLastPage == true) {
                $('#loadMoreButton').hide();
            }
        }
    });
});