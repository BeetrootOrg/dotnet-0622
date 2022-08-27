
function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
  }
var superAudio = document.getElementById("super-bonk-audio");
superAudio.addEventListener('ended', function () {
    sleep(500).then(() => {
        this.currentTime = 0;
        this.play();
        })
}, false);
