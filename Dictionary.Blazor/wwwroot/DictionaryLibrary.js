// DictionaryLibrary.js

window.ChangeUrl = function (url) {
    history.pushState(null, '', url);
}

// Enter key to search:
window.ClickButtonByID = function (elementID) {
    document.getElementById(elementID).click();
}