function toonPrompt() {

    var code = prompt('Vul uw promotiecode in', 'uw code');
    document.getElementById('btnPrompt').innerHTML = 'De code die u invoerde was: ' + code;
}