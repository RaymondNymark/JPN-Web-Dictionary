// DictionaryLibrary.js

window.ChangeUrl = function (url) {
    history.pushState(null, '', url);
}