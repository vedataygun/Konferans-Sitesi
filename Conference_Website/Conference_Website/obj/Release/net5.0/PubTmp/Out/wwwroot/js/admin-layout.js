
let hbgr_menu = document.getElementById("hbgr-menu");

hbgr_menu.addEventListener("click", function () {
    document.querySelector(".aside").classList.toggle("active");
    document.querySelector("main").classList.toggle("wdt100dvc");
    document.querySelector("body").classList.toggle("overflow-hidden");

})





$(".alrtbox-close-btn").click(function () {
    this.parentElement.classList.remove("active");
})


setTimeout(() => {
    $(".alrtbox").addClass("active");

    setTimeout(() => {
        $(".alrtbox").removeClass("active");
    }, 4000)
}, 1000)




