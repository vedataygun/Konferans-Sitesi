let status = false;

const AlertType = {
    Info: 0,
    Warning: 1,
    Danger: 2,
    Success: 3
}

function getIcon(Type) {

    switch (Type) {
        case AlertType.Info:
            return '< i class="fa-solid fa-circle-info" ></i >'
            break;
        case AlertType.Warning:
            return '<i class="fa-solid fa-triangle-exclamation"></i>'
            break;
        case AlertType.Success:
            return '<i class="fa-solid fa-circle-check"></i>'
            break;
        case AlertType.Danger:
            return '<i class="fa-sharp fa-solid fa-circle-xmark"></i>'
            break;
        default:
            return null
            break;

    }
}

function getAlert(alertBox) {

    let randomID = Math.floor(Math.random() * 100) + 1;

    if (status==false) {
        
        let alert = `<div id="${randomID}" class="alrtbox alrtbox-${alertBox.typeString.toLowerCase()}" data-theme="dark" >
                        <div class="alr-container">
                                ${getIcon(alertBox.type)}
                            <div class="alrt-msg">
                                <span>${alertBox.header}</span>
                                <p>${alertBox.message}</p>
                            </div>
                        </div>
                        <i class="fa-solid fa-xmark alrtbox-close-btn"></i>
                    </div >`;


        let body = document.querySelector("body");
        body.insertAdjacentHTML("beforeend", alert);

        setTimeout(() => {
            document.getElementById(randomID).classList.add("active");
            status = true;

            setTimeout(() => {
                document.getElementById(randomID).classList.remove("active");
                status = false;

            }, 4000)
        }, 150);

    }


}
