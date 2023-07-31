
function sliderChange() {
    sliderRemoveClassAll()
    this.classList.add("featured")
}

function sliderRemoveClassAll() {
    $(".slider .image-container").removeClass("featured");
}

$(document).on("click", ".slider .image-container", sliderChange);