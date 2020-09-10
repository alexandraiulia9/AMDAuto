
const welcomeTitle = document.querySelector('#welcomeTitle');
const quote = document.querySelector('#quote');
const welcomePhoto = document.querySelector('#welcomePhoto');
const slider = document.querySelector('.slider');

const tl = new TimelineMax();

tl.fromTo(welcomePhoto, 0.7, { width: "0%" }, { width: "100%", ease: Power2.easeInOut })
    .fromTo(welcomePhoto, 0.7, { width: "100%" }, { width: "80%", ease: Power2.easeInOut })
    .fromTo(welcomePhoto, 0, { x: "0%" }, { x: "10%", ease: Power2.easeInOut }, "-=0.7")
    .fromTo(slider, 1, { x: "-100%" }, { x: "0%", ease: Power2.easeInOut }, "-=0")
    .fromTo(welcomeTitle, 0.5, { x: "-100%" }, { x: "0%", ease: Power2.easeInOut })
    .fromTo(quote, 0.5, { x: "-200%" }, { x: "30%", ease: Power2.easeInOut }, "-=0.5")

