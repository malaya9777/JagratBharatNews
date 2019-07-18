
let menu = document.getElementById('menu');
let close = document.getElementById('close');
let floatingMenu = document.getElementById('floatingMenu');
menu.addEventListener("click",function(){
    floatingMenu.classList.add('fadeIn');
    
    
});
close.addEventListener("click",function(){
    floatingMenu.classList.add('fadeOut');
    setTimeout(function(){
        floatingMenu.classList.remove('fadeOut');
        floatingMenu.classList.remove('fadeIn');
    },1000);

});

let textWidht = document.getElementById("scroll");
let textp = document.getElementById("ctl00_ContentPlaceHolder1_para");
textWidht.style.width = textp.scrollWidth+"px";
textp.style.animationDuration = (textp.scrollWidth / 100) * 4 + "s";
console.log(textp.scrollWidth);

