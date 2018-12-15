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

/////////////////////////Details////////////////////////////////////////
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

    var tableMcq = "<td> <input type='hidden' id='tableMcq" + index + "'  name='Answers[" + index + "].Result' value='" + selectedItem.MCQ + "' /> " + selectedItem.OPT + " </td>";
    var tableAnswer1 = "<td> <input type='hidden' id='tableAnswer1" + index + "'  name='Answers[" + index + "].Answer1' value='" + selectedItem.Answer + "' /> " + selectedItem.Answer + " </td>";
    var tableDelete = "<td> <input type='button' id='tableDelete" + index + "'  value='-' class='btn btn-danger btn-xs' />  </td>";
    var tableAOrder = "<td> <input type='hidden' id='tableAOrder" + index + "'  name='Answers[" + index + "].AOrder' value='" + selectedItem.Order + "' /> " + selectedItem.Order + " </td>";



    var newRow = "<tr>" + indexTd + slTd + tableMcq + tableAnswer1 + tableDelete + tableAOrder + " </tr>";

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
