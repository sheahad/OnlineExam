$(document.body).on("click","#CourseCreateButton",function() {
    getCourseCreatePv();
});

function getCourseCreatePv() {
    var url = "/Course/GetCourseCreatePv";
    $.post(url, function(rData) {
        if (rData != undefined && rData != "") {
            $("#PartialLoadDiv").html(rData);
        }
    });

}

