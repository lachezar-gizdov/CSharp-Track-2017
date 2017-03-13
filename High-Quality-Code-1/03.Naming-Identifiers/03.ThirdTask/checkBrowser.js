function _ClickON_TheButton(THE_event, args) {
    var myWindow = window,
        browser = myWindow.navigator.appCodeName,
        isMyBrowser = browser == "Mozilla";

    if (isMyBrowser) {
        alert("Yes");
    } else {
        alert("No");
    }
}