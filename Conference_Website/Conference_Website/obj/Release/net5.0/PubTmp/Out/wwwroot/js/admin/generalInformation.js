
/*-----------     Detail Edit    ----------------  */

let detail_form = document.getElementById("Detail");

detail_form.addEventListener("submit", function (e) {
    e.preventDefault();
    let ConferenceName = e.target.elements.ConferenceName.value;
    let StartDate = e.target.elements.StartDate.value;
    $.ajax({
        type: "Post",
        url: e.target.action,
        dataType: "Json",
        cache: false,
        data: { ConferenceName, StartDate },
        success: function (response) {
            if (response.isSuccess)
                getAlert(response.alert)
        }

    })
})

////////////


/*-----------     Delete Image          -----------------  */


$(document).on("click", ".image-container button", function () {
    this.parentElement.remove();
    setTimeout(() => {
        document.querySelector(".image-container")?.classList.add("featured");
    }, 500)
    deleteImage(this.getAttribute("id"));
    classChange();
})



function deleteImage(ImageName) {
    $.ajax({
        type: "Post",
        url: "/admin/Delete_Image",
        dataType: "Json",
        cache: false,
        data: { ImageName },
        success: function (response) {
            if (response.isSuccess)
                getAlert(response.alert)
        }

    })

}

////////


/*-----------     Add Image          -----------------  */

let file_image = document.getElementById("file_image");
let addImage_from= document.getElementById("addImageForm");



$("#select-image").click(function () {
    file_image.click();
})


file_image.addEventListener("change", function (e) {
    let newImageName = CreateUUID();
    addImage(file_image.files[0], newImageName);
})



function addImage(Image, ImageName){
    let form = new FormData();
    form.append("Image", Image);
    form.append("ImageName", ImageName);

    $.ajax({
        type: "post",
        url: "/admin/Add_Image",
        data: form,
        cache: false,
        contentType: false,
        processData: false,
        success: function (response) {          
            getAlert(response.alert)
            if (response.isSuccess)
                addDocumentImage(ImageName);
        }
   })
   
}



function addDocumentImage(ImageName) {
    var reader = new FileReader();
    let extension = getFileExtension(file_image.files[0].name);

    reader.readAsDataURL(file_image.files[0]);
    reader.onload = function () {
        classChange();
        let id = Math.floor(Math.random() * 100) + 50;
        sliderRemoveClassAll();
        document.querySelector(".slider").innerHTML += ` <div id="${id}"  class="image-container featured">
                        <button type="button" id="${ImageName + extension}">
                            <i class="fa-regular fa-trash-can"></i>
                        </button>
                        <img src="${reader.result}" alt="">
                        
                    </div>`;
    }
}


/*-----------     New Unique Id      -----------------  */

function CreateUUID() {
    return ([1e7] + -1e3 + -4e3 + -8e3 + -1e11).replace(/[018]/g, c =>
        (c ^ crypto.getRandomValues(new Uint8Array(1))[0] & 15 >> c / 4).toString(16)
    )
}




/*-----------     Class Arrangement by Number of Pictures   -----------------  */

function classChange() {
    let nodeCount = document.querySelectorAll(".image-container").length;

    if (nodeCount > 4) 
        document.querySelector("main .sec-2 .col-1").classList.remove("direction-row");
    else
     document.querySelector("main .sec-2 .col-1").classList.add("direction-row");
    
}

///////////



/*-----------    File Extension    -----------------  */

function getFileExtension(fileName) {
    return ".".concat(fileName.slice((fileName.lastIndexOf(".") - 1 >>> 0) + 2));

}

///////////





/*-----------    Speaker Delete    -----------------  */


$(document).on("click", ".speaker-delete-btn", speakerDelete);


function speakerDelete() {
    var parentElement = this.parentElement.parentElement;
    $.ajax({
        type: "Post",
        url: "/admin/Delete_Speaker",
        data: { id: this.getAttribute("id") },
        success: function (response) {
            getAlert(response.alert)
            if (response.isSuccess) {
                parentElement.remove();
            }
        }

    })
}

///////////





/*-----------    Add-Edit Speaker Form    -----------------  */



$("#addSpeaker").click(function () {
    SpeakerFormRemove();

    if ($("#addSpeaker_form").select().length > 0)
        SpeakerFormRemove();  
        else
        $("#speakerListDiv").before(getForm());

})



$(document).on("click", "#speakerAddImage" ,function () {
    $("#addSpeakerInputFile").click();
})

$(document).on("click", "#closeAddSpeakerForm", function () {
    
    documentWriteSpeakerList();
    $("#addSpeaker_form").remove();
})


$(document).on("click", ".speaker-edit-btn", function () {
    let mainElement = $(this).parents(".speaker-items")[0];
    let id = this.getAttribute("id");
    SpeakerFormRemove();
    getSpeakerDetail(id, mainElement);
})





$(document).on("submit", "#addSpeaker_form", function (e)  {
    e.preventDefault();
    var formdata = new FormData(this);

    if (e.target.elements.id.value != 0)
        updateSpeaker(formdata);
    else
        addSpeaker(formdata);
    
        
})


function SpeakerFormRemove() {

    let count = $("#addSpeaker_form").select().length;

    if (count > 0) {
        documentWriteSpeakerList();
        $("#addSpeaker_form").remove();
    }

}



function addSpeaker(formData) {
    $.ajax({
        type: "Post",
        url: "/admin/Add_Speaker",
        data: formData,
        cache: false,
        contentType: false,
        processData: false,
        success: function (response) {
            if (response.isSuccess) {
                getAlert(response.alert)
                documentWriteSpeakerList(); 
            }
        }

    })
}

function updateSpeaker(formData) {

 
    $.ajax({
        type: "Post",
        url: "/admin/Update_Speaker",
        data: formData,
        cache: false,
        contentType: false,
        processData: false,
        success: function (response) {
            if (response.isSuccess) {
                getAlert(response.alert)

                documentWriteSpeakerList();
            }

        }

    })
}

function getSpeakerDetail(id, mainElement) {
    $.ajax({
        type: "Post",
        url: "/admin/Get_SpeakerDetail",
        data: {id},
        success: function (response) {
            if (response.isSuccess) {
                let item = response.data[0];
                mainElement.innerHTML = getForm(item);
            }
        }

    })
}


function getForm(item) {

    

    return `
                    <form id="addSpeaker_form" enctype="multipart/form-data" class="addSpeaker-form">
    <div class="row-1">
        <div class="col-1">
            <input type="file" name="newImage" id="addSpeakerInputFile" />
            <img src="/img/${item != undefined ? item.image : "camera.png"}" id="speakerAddImage"/>
        </div>
        <div class="col-2">
            <button type="submit">
                <span><i class="fa-solid fa-arrow-up"></i></span>
                Kaydet
            </button>
           <button id="closeAddSpeakerForm" type="button">
                    Kapat
            </button>
        </div>
    </div>
    <div class="row-2">
        <input type="hidden" name="Image" value="${item != undefined ? item.image : ""}" />
        <input type="hidden" name="id" value="${item != undefined ? item.id : 0}" />
        <input type="text" name="NameAndSurname" value="${item != undefined ? item.nameAndSurname: ""}" placeholder="Ad Soyad" />
        <textarea name="Description"   placeholder="Açıklama">${item != undefined ? item.description : ""}</textarea>
        <input type="text" name="Career"  value="${item != undefined ? item.career : ""}" placeholder="Kariyer" />
    </div>
</form>
                `;
}


function documentWriteSpeakerList(){
    $.ajax({
        type: "Post",
        url: "/admin/GetAll_Speaker",
        data: {},
        success: function (response) {
            if (response.isSuccess) {
                $("#speakerListDiv").html("");
                response.data.forEach(item => {
                    $("#speakerListDiv").append(speakerDivDesign(item));
                })
            }

        }

    })
   
}

function speakerDivDesign(item) {
    return `
        <div class="speaker-items">
                    <div>
                    <img src="/img/${item.image}" />
                        <span>${item.nameAndSurname}</span>
                    </div>
                    <div>
                        <button  class="speaker-delete-btn"  id="${item.id}">
                              <i class="fa-regular fa-trash-can"></i>
                         </button>
                        <button class="speaker-edit-btn" id="${item.id}" type="button">
                            <i class="fa-regular fa-pen-to-square"></i>
                         </button>
                     </div>
                </div>
    `;
}

///////////



/*-----------     Agenda Form   -----------------  */




/*-  Input Settings  -  */


$(".agendaInput").keydown(function (e) {
    let key = e.charCode || e.keyCode || 0;

    let value = e.target.value;
    if (value.length == 2 && key != 8)
        e.target.value = value + ":";


    if (((key >= 96 && key <= 105) ||
        (key >= 48 && key <= 58) || key == 8) && (value.length < 5 || key == 8)) {
        return true;
    }                
    else
        return false;
})



$(".agendaInput").blur(function (e) {
    let value = e.target.value;


    if (value.slice(3, 5) == "" && value != "" )
        e.target.value = value.slice(0, 2) + ":00";



    if (value.slice(3, 5) > 59)
        e.target.value = value.slice(0, 2) + ":00";


    if (value.slice(0, 2) > 23)
        e.target.value = "00:00";

        
})

//----


$(document).on("click", ".buttonAgendaRemove", function () {
    let id = this.getAttribute("id");

    $.ajax({
        url: "/admin/Remove_Agenda",
        type: "Post",
        data: { id },
        success: function (response) {
            if (response.isSuccess) {
                $("#agendaList").html(agendaDivDesign(response.data));

                getAlert(response.alert)
               
            }
        }

     })
})


$("#agendaAddForm").submit(function (e) {
    e.preventDefault();
    $.ajax({
        type: "Post",
        url: "/admin/Add_Agenda",
        data: new FormData(this),
        contentType: false,
        cache: false,
        processData: false,
        success: function(response)
        {
            if (response.isSuccess) {
                $("#agendaList").html(agendaDivDesign(response.data));
                
                getAlert(response.alert)

            }
        }
     })

})



function agendaDivDesign(items) {

    items.sort(agendaSortArray);
    console.log(items);
    let divList = items.map((e,i) => {
        return `
           <div class="item ${i == 0 ? "first" : ""}">
                            <span>${e.startTime}${e.endTime != "" && e.endTime != null && e.endTime != e.startTime ? " - " + e.endTime : ''}</span>
                        <button id="${e.id}" class="buttonAgendaRemove"><i  class="fa-solid fa-trash"></i></button>
                            <span>${e.description}</span>
                        </div>
    `;
    });
    return divList;
}

function agendaSortArray(a, b) {
  
    if (a.startTime < b.startTime)
        return -1;
    if (a.startTime > b.startTime)
        return 1;
    return 0;
}

//////////////////






/*-----------     Map   -----------------  */

let lat, long = 0;

let addressList = [];


$("#searchAddress").keydown(function (e) {
    if (e.target.value.length > 3) 
        getAdress(e.target.value);
    else 
        $("#adressList").removeClass("active");
    
})

$("#adressList").change(function (e) {
    let index = this.options[this.selectedIndex].value;

    let address = addressList.filter(e => {
        if (e.place_id == index)
            return e;
    })[0];

    lat = address.geometry.location.lat;
    long = address.geometry.location.lng;
    Admin_initMap(lat, long);
    
})


$("#mapForm").submit(function (e) {
    e.preventDefault();
    let address = $("#txtarea-adressDetail").html();
    $.ajax({
        type: "post",
        url: "/admin/Update_Location",
        data: { lat, long, address },
        success: function (response) {
            if (response.isSuccess) {
                getAlert(response.alert)
            }
        }
        })
})


$("#txtarea-adressDetail").blur(function (e) {
    if (e.target.innerHTML == "")
        e.target.innerHTML = this.getAttribute("data-placeholder");
})


function getAdress(address) {
    let apikey = "AIzaSyArt62EWCRmppuo5ifGTeujORCcWSP7hxk";
    var url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + address + "&key=" + apikey;
    fetch(url).then(response => response.json()).then(
        data => {
            addressList = [...new Set(data.results.map(item => item))]

            
            if (addressList.length > 0) {
                $("#adressList").html("");
                $("#adressList").append("  <option selected disabled>Konum Seçiniz</option>");
                $("#adressList").addClass("active");
                addressList.forEach(e => {
                    $("#adressList").append(`<option value="${e.place_id}">${e.formatted_address}</option>`)
                })
            }
       

        
    });
}


function Admin_initMap(latitude , longitude , elementId = "map") {

    lat = parseFloat(latitude == undefined ? $("#lat").val() : latitude);
    long = parseFloat(latitude == undefined ? $("#long").val() : longitude);

  

    let map = new google.maps.Map(document.getElementById(elementId), {
        center: { lat: lat, lng: long },
        zoom: 12,
        styles: [
            { elementType: "geometry", stylers: [{ color: "#242f3e" }] },
            { elementType: "labels.text.stroke", stylers: [{ color: "#242f3e" }] },
            { elementType: "labels.text.fill", stylers: [{ color: "#746855" }] },
            {
                featureType: "administrative.locality",
                elementType: "labels.text.fill",
                stylers: [{ color: "#d59563" }],
            },
            {
                featureType: "poi",
                elementType: "labels.text.fill",
                stylers: [{ color: "#d59563" }],
            },
            {
                featureType: "poi.park",
                elementType: "geometry",
                stylers: [{ color: "#263c3f" }],
            },
            {
                featureType: "poi.park",
                elementType: "labels.text.fill",
                stylers: [{ color: "#6b9a76" }],
            },
            {
                featureType: "road",
                elementType: "geometry",
                stylers: [{ color: "#38414e" }],
            },
            {
                featureType: "road",
                elementType: "geometry.stroke",
                stylers: [{ color: "#212a37" }],
            },
            {
                featureType: "road",
                elementType: "labels.text.fill",
                stylers: [{ color: "#9ca5b3" }],
            },
            {
                featureType: "road.highway",
                elementType: "geometry",
                stylers: [{ color: "#746855" }],
            },
            {
                featureType: "road.highway",
                elementType: "geometry.stroke",
                stylers: [{ color: "#1f2835" }],
            },
            {
                featureType: "road.highway",
                elementType: "labels.text.fill",
                stylers: [{ color: "#f3d19c" }],
            },
            {
                featureType: "transit",
                elementType: "geometry",
                stylers: [{ color: "#2f3948" }],
            },
            {
                featureType: "transit.station",
                elementType: "labels.text.fill",
                stylers: [{ color: "#d59563" }],
            },
            {
                featureType: "water",
                elementType: "geometry",
                stylers: [{ color: "#17263c" }],
            },
            {
                featureType: "water",
                elementType: "labels.text.fill",
                stylers: [{ color: "#515c6d" }],
            },
            {
                featureType: "water",
                elementType: "labels.text.stroke",
                stylers: [{ color: "#17263c" }],
            },
        ],
    });

    let marker = new google.maps.Marker({
        position: new google.maps.LatLng(lat, long),
        map: map,
        draggable: true
    });

    marker.addListener("drag", (googleMapsEvent) => {
        lat = googleMapsEvent.latLng.lat();
        long = googleMapsEvent.latLng.lng();
    })

}

