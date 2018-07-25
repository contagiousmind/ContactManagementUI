/// <reference path="Base.js" />

$(function () {

});


function TestClick() {
    var params = "WebControl.mwh?Method=GetArtists&Template=BrowseContact.htm";

    SendAjax(params, function (data) {
        $("#MainArtistPanel").html(data.Data);

    });
}

function GetAlbums(artistID) {
    var params = "WebControl.mwh?Method=GetAlbums&ArtistID=" + artistID;

    SendAjax(params, function (data) {
        $("#MainAlbumPanel").html(data.Data);

    });
}


