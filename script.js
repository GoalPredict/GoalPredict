function startCountdown() {
    let time = 2 * 60 * 60; // 2 hours in seconds
    const countdownEl = document.getElementById("countdown");

    const interval = setInterval(() => {
        if (!countdownEl) return;

        let hours = Math.floor(time / 3600);
        let minutes = Math.floor((time % 3600) / 60);
        let seconds = time % 60;

        hours = hours.toString().padStart(2, "0");
        minutes = minutes.toString().padStart(2, "0");
        seconds = seconds.toString().padStart(2, "0");

        countdownEl.textContent = `${hours}h ${minutes}m ${seconds}s`;

        time--;

        if (time < 0) {
            time = 2 * 60 * 60; // reset
        }
    }, 1000);
}

startCountdown();
