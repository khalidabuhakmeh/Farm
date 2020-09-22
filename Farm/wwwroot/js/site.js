function initAudio(element, reference){
    element.addEventListener("ended", async e => {
        await reference.invokeMethodAsync("OnEnd");
    });
}

function playAudio(element) {
    stopAudio(element);
    element.play();
}

function stopAudio(element) {
    element.pause();
    element.currentTime = 0;
}