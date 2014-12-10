$(document).ready(function () {
    $(".dropDown").change(function () {
        var id = $(this).attr('id');
        var val = $(this).val();
        $("#" + id + "Desc").text = $("#" + val + "Desc").val();
    })
});