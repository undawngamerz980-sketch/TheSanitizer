// List of timezones with their UTC offsets
const timezones = {
    est: { offset: -5, name: 'est-date' },
    cst: { offset: -6, name: 'cst-date' },
    mst: { offset: -7, name: 'mst-date' },
    pst: { offset: -8, name: 'pst-date' },
    gmt: { offset: 0, name: 'gmt-date' },
    cet: { offset: 1, name: 'cet-date' },
    ist: { offset: 5.5, name: 'ist-date' },
    jst: { offset: 9, name: 'jst-date' },
    sgt: { offset: 8, name: 'sgt-date' },
    hkt: { offset: 8, name: 'hkt-date' },
    aest: { offset: 10, name: 'aest-date' },
    nzst: { offset: 12, name: 'nzst-date' }
};

function updateClocks() {
    const now = new Date();
    const utcTime = now.getTime() + now.getTimezoneOffset() * 60000;

    for (const [key, tz] of Object.entries(timezones)) {
        // Calculate the timezone time
        const tzTime = new Date(utcTime + tz.offset * 60 * 60 * 1000);

        // Format time
        const hours = String(tzTime.getHours()).padStart(2, '0');
        const minutes = String(tzTime.getMinutes()).padStart(2, '0');
        const seconds = String(tzTime.getSeconds()).padStart(2, '0');
        const timeString = `${hours}:${minutes}:${seconds}`;

        // Determine AM/PM
        const hourNum = parseInt(hours);
        const period = hourNum >= 12 ? 'PM' : 'AM';

        // Format date
        const options = { weekday: 'short', year: 'numeric', month: 'short', day: 'numeric' };
        const dateString = tzTime.toLocaleDateString('en-US', options);

        // Update DOM
        document.getElementById(key).textContent = timeString;
        document.getElementById(key + '-period').textContent = period;
        document.getElementById(tz.name).textContent = dateString;
    }
}

// Update clocks immediately and then every second
updateClocks();
setInterval(updateClocks, 1000);