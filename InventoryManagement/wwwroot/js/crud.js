const noImageSRC = "/dist/img/no-image-icon-15.png"
//Remove fields
function removeField(...fields){
    fields.forEach(field => {
        field.value = "";
    });
}
function disableMultipleFields(...fields){
    fields.forEach(field => {
        field.disabled = true;
    });
}

function disableSingleField(field){
    field.disabled = true;
}


function enableMultipleFields(...fields){
    fields.forEach(field => {
        field.disabled = false;
    });
}

function enableSingleField(field){
    field.disabled = false;
}


function hideMultipleSections(...fields){
    fields.forEach(field => {
        field.classList.add("d-none");
    });
}

function hideSingleSection(field){
        field.classList.add("d-none");
}


function visibleMultipleSections(...fields){
    fields.forEach(field => {
        field.classList.remove("d-none");
    });
}

function visibleSingleSection(field){
        field.classList.remove("d-none");
}


//Remove fields and set default values
function setDVOnMultipleInput(value ,...fields){
    fields.forEach(field => {
        field.value = 0;
    });
}

function printFormData(formData) {
    console.log([...formData.entries()])
}

function removeAllOptions(selectElement) {
    // Remove all options from the select list
    while (selectElement.options.length > 1) {
        selectElement.remove(1);
    }
}

function generateSelectListOptions(tag, text, value) {
    let options = document.createElement("option");
    options.value = value;
    options.textContent = text;
    tag.appendChild(options);
}


//Remove remove selet list option and set default option
function resetSelectList(...selectLists) {
    selectLists.forEach(selectList => {
        if (selectList && selectList.options.length > 0) {
            selectList.options[0].selected = true;
        }
    });
}

//Get something by id and return the json
async function getByIdAsync(url, id) {
    try {
        const response = await fetch(`${url}?id=${parseInt(id)}`, {
            method: 'GET'
        });

        if (!response.ok) {
            throw new Error('Failed to fetch data');
        }

        const data = await response.json();
        return data;
    } catch (error) {
        console.log("There was an error processing the response: " + JSON.stringify(error));
        throw error; // rethrow the error to propagate it to the caller
    }
}

function getById(url, id, callback){
    try{
        fetch(`${url}?id=${parseInt(id)}`,{
            method:'GET'
        }).then(response =>{
            if (!response.ok){
                throw new Error('Failed to fetch data');
            }
            return response.json()})
        .then(data => callback(data))
        .catch(error => console.log('There was an error while getting the catalog.'))

    }catch(error){
      console.log("Internal Server Error")
      callback(null)
    }
}
async function getData(url){
    const response = await fetch(url,{
        method:"POST"
    })
    const data = await response.json();
    return data;
}

//  Add the fetch request 
async function AddData(Url, body) {
    const response = await fetch(Url, {
        method: "POST",
        body: body,

    });
    let data = await response.json();
    console.log(data)
}

//Editing Data
async function edit(Url, body) {
    const response = await fetch(Url, {
        method: "POST",
        body: body,

    });
    let data = await response.json();
    console.log(data)
}


//Delete Data
async function Delete(url, id){
    try {
       const response = await fetch(`${url}?id=${parseInt(id)}`, {
           method: 'POST'
       });

       if (!response.ok) {
           throw new Error('Network response was not ok');
       }

       const data = await response.json();
       console.log(data)
   } catch (error) {
       console.error('Error:', error);
   }
}