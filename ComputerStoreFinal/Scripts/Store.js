$(document).ready(function () {
    $(".dropDown").bind('change', function () {
        var id = $(this).attr('id');
        var val = $(this).val();
        $("#" + id + "Desc").text($("#" + val + "Desc").text());
    })

    $(".dropDown").trigger('change');
});