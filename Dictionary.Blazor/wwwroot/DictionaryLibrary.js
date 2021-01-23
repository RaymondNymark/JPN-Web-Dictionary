// DictionaryLibrary.js

// Change the page's URL function:
window.ChangeUrl = function (url) {
    history.pushState(null, '', url);
}

// Enter key to search:
window.ClickButtonByElementID = function (elementID) {
    document.getElementById(elementID).click();
}