/// <reference path="jquery-3.0.0.js" />

$(function () {


});


function SendAjax(params, completeEvent) {
    $.ajax({
        url: params,
        async: true,
        cache: false,
        type: "POST",
        dataType: "json",
        data: "",
        success: function (data, textStatus, jqXHR) {

            if (completeEvent) {
                completeEvent.call(this, data);
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            if (completeEvent) {
                //var ajaxJson = new AjaxJson();
                //ajaxJson.ErrorMessage = textStatus;
                //ajaxJson.Status = -1;
                //completeEvent.call(this, ajaxJson);
            }
        }
    });
}
