const alertCloseBtn = document.querySelector(".alrtbox-close-btn");

alertCloseBtn.addEventListener("click", function () {
    this.parentElement.classList.remove("active");
})


setTimeout(() => {
    document.querySelector(".alrtbox").classList.add("active");

    setTimeout(() => {
        document.querySelector(".alrtbox").classList.remove("active");
    },4000)
},1000)