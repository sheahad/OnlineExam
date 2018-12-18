$("#OrganizationId").change(function () {
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
            if (response !== undefined && response !== null && response !== "") {
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
            if (response !== undefined && response !== null && response !== "") {
                $("#ExamId").empty();
                $("#ExamId").append('<option>---Select---</option>');
                $.each(response, function (k, v) {
                    $("#ExamId").append("<option value='" + v.Id + "'>" + v.Name + "</option>");
                });
            }
        }
    });
});


$("#ExamId").change(function () {
    var examId = $(this).val();
    // Variable: value
    var params = { examId: examId }
    $.ajax({
        type: "POST",
        //controller/Action 
        url: "../../QuistionAnswer/GetQuestionByXxamId",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(params),
        success: function (response) {
            if (response !== undefined && response !== null && response !== "") {
                $("#qsn").empty();
                //$("#qsn").append('<option>---Select---</option>');
                $.each(response, function (k, v) {
                    var order = "<td>" +v.QOrder +"</td>";
                    var qsn = "<td class='col-md-3'>" + v.Question1 + "</td>";
                    var disqsntype = "";
                    if (v.QuestionType ==1)
                        disqsntype = "<input type='radio' checked disabled readonly />";

                    if (v.QuestionType == 2)
                        disqsntype = "<input type='checkbox' checked disabled readonly />";

                    var qsntype = "<td class='col-md-2'>" + disqsntype + "</td>";

                    var options = "<td class='col-md-1'>"+v.Option+"</td>";
                    var action = "<td class='col-md-4'> <input type='button' name='viewRow' value='View' class='btn btn-success btn-xs' /><input type='button' name='editRow' value='Edit' class='btn btn-block btn-xs' /><input type='button' name='deleteRow' value='Delete' class='btn btn-danger btn-xs' /></td>";
                    
                    //$("#qsn").append("<option value='" + v.Id + "'>" + v.Name + "</option>");
                    $("#qsn").append("<tr>" + order + qsn + qsntype + options + action + "</tr>");
                    $("#QOrder").val(v.QOrder + 1);
                });
            }
        }
    });
});


/* ************************ ************************** ******************** ********************** */
/* ************************ ************************** ******************** ********************** */
$("#answerDiv").hide();
$("#chkMcq").hide();
$("#rdoMcq").hide();

$("#QuestionType").change(function () {
    var questionType = $(this).val();
    var textArea = "";
    $("#tableAOrder").val(1);
    if (questionType === "1") {
        $("#chkMcq").hide();
        $('#chkMcq').prop('checked', false);
        $("#rdoMcq").show();
       $("#answerDiv").show();
    }else if (questionType === "2") {
        $("#rdoMcq").hide();
        $('#rdoMcq').prop('checked', false);
        $("#chkMcq").show();
        $("#answerDiv").show();
    }
    else if (questionType === "0") {
        $("#chkMcq").hide();
        $('#chkMcq').prop('checked', false);
        $("#rdoMcq").hide();
        $('#rdoMcq').prop('checked', false);
        $("#answerDiv").hide();
    }
});
/* ************************ ************************** ******************** ********************** */
/////////////////////////Details//////////////////////////////////
$("#AddButton").click(function () {
    createRowForPurchase();

});


var index = 0;
function createRowForPurchase() {
    //Get Selected Item from UI
    var selectedItem = getSelectedItem();

    //Check Last Row Index
    var index = $("#AnswersTable").children("tr").length;
    var sl = index;

    //For Model List<Property> Binding For MVC
    var indexTd = "<td style='display:none'><input type='hidden' id='Index" + index + "' name='Answers.Index' value='" + index + "' /> </td>";

    //For Serial No For UI
    var slTd = "<td id='Sl" + index + "'> " + (++sl) + " </td>";

    //Dispale & Send Data to MVC
    var tableMcq = "<td> <input type='hidden' id='tableMcq" + index + "'  name='Answers[" + index + "].Result' value='" + selectedItem.MCQ + "' /> " + selectedItem.OPT + " </td>";
    var tableAnswer1 = "<td> <input type='hidden' id='tableAnswer1" + index + "'  name='Answers[" + index + "].Answer1' value='" + selectedItem.Answer + "' /> " + selectedItem.Answer + " </td>";
    var tableDelete = "<td> <input type='button' id='tableDelete" + index + "' value='-' class='btn btn-danger btn-xs btnDelete' /></td>";
    var tableAOrder = "<td> <input type='hidden' id='tableAOrder" + index + "'  name='Answers[" + index + "].AOrder' value='" + selectedItem.Order + "' />  </td>";

    //Create Row
    var newRow = "<tr>" + indexTd + slTd + tableMcq + tableAnswer1 + tableDelete + tableAOrder + " </tr>";

    //
    $("#AnswersTable").append(newRow);
    $('#chkMcq').prop('checked', false);
    $('#rdoMcq').prop('checked', false);
    $("#tableAnswer1").val("");
    $("#tableAOrder").val((++sl));
}


function getSelectedItem() {
    var questionType = $("#QuestionType").val();
    var aOrder = $("#tableAOrder").val();
    var opt = "";
    var mcq = 0;

    if (questionType === "1") {
        if ($("#rdoMcq").is(":checked")) {
            mcq = 1;
            opt = "<input type='radio' checked disabled readonly />";
        }
        
        else
            opt = "<input type='radio' disabled readonly />";
    } else if (questionType === "2") {
        if ($("#chkMcq").is(":checked")) {
            mcq = 1;
            opt = "<input type='checkbox' checked disabled readonly />";
        }
        
        else
            opt = "<input type='checkbox' disabled readonly />";
    }
    
    var answer = $("#tableAnswer1").val();

    var item = {
        "MCQ": mcq,
        "OPT": opt,
        "Order": aOrder,
        "Answer": answer
    }

    return item;
}

$(document).ready(function () {

    $("#AnswersTable").on('click', '.btnDelete', function () {
     
        $(this).closest('tr').remove();
    });

});
