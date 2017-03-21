function buttonClock(event, args) {
    let myWindow = window,
        browser = myWindow.navigator.appCodeName,
        isMyBrowserMozzila = browser === "Mozilla";

    if (isMyBrowserMozzila) {
        alert("Yes");
    } else {
        alert("No");
    }
}