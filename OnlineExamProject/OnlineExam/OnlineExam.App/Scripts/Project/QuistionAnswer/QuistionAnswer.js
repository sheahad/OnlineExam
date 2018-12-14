﻿$("#OrganizationId").change(function () {
    var organizationId = $(this).val();
    // Variable: value
    var params = { organizationId: organizationId }
    $.ajax({
        type: "POST",
        //controller/Action 
        url: "../../QuistionAnswer/GetCourseByOrganizationId",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(params),
        success: function (response) {
            if (response != undefined && response != null && response != "") {
                $("#CourseId").empty();
                $("#CourseId").append('<option>---Select---</option>');
                $("#ExamId").empty();
                $("#ExamId").append('<option>---Select---</option>');
                $.each(response, function (k, v) {
                    $("#CourseId").append("<option value='" + v.Id + "'>" + v.Name + "</option>");
                });
            }
        }
    });
});

$("#CourseId").change(function () {
    var courseId = $(this).val();
    // Variable: value
    var params = { courseId: courseId }
    $.ajax({
        type: "POST",
        //controller/Action 
        url: "../../QuistionAnswer/GetExamByCourseId",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(params),
        success: function (response) {
            if (response != undefined && response != null && response != "") {
                $("#ExamId").empty();
                $("#ExamId").append('<option>---Select---</option>');
                $.each(response, function (k, v) {
                    $("#ExamId").append("<option value='" + v.Id + "'>" + v.Name + "</option>");
                });
            }
        }
    });
});

$("#answerDiv").hide();

$("#questionTypeSelect").change(function () {
    var questionType = $(this).val();
    var textArea = "";
    if (questionType == "1") {
        textArea = "<input type='Radio' Name='rdoMcq' Value=''/>";
        $("#mcqDiv").html(textArea);
       $("#answerDiv").show();
    }else if (questionType == "2") {
        textArea = "<input type='Checkbox' name='chkMcq' value=''/>";
        $("#mcqDiv").html(textArea);
        $("#answerDiv").show();
    }
    else if (questionType == "0") {
        $("#mcqDiv").html("");
        $("#answerDiv").hide();
    }
});