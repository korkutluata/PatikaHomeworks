let userName = prompt("Lutfen isminzi giriniz: ");
let user = document.querySelector('#myName');
user.innerHTML = userName;


let timeText = document.querySelector('#myClock');
function timeNow() {
    let tarih = new Date();
    let gunler = ['Pazar', 'Pazartesi', 'Sali', 'Carsamba', 'Persembe', 'Cuma', 'Cumartesi'];
    let gun = gunler[tarih.getDay()];
    let saat = tarih.getHours();
    let dakika = tarih.getMinutes();
    let saniye = tarih.getSeconds();
    timeText.innerHTML = `
    ${saat}:${dakika}:${saniye} / ${gun}
    `
}
setInterval(timeNow, 1000);