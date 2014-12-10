$(document).ready(function () {
    $(".dropDown").bind('change', function () {
        var id = $(this).attr('id');
        var val = $(this).val();
        $("#" + id + "Desc").text($("#" + val + "Desc").text());
        $("#" + id + "Img").attr('src', $("#" + val + "Img").text())
        $("#" + id + "Img").removeAttr('hidden');
    })

    $(".dropDown").trigger('change');
});