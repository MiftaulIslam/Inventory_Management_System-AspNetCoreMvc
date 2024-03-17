//Remove fields
function removeField(...fields){
    fields.forEach(field => {
        field.value = "";
    });
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
async function getById(url, id){
    try {
       const response = await fetch(`${url}?id=${parseInt(id)}`, {
           method: 'GET'
       });

       if (!response.ok) {
           throw new Error('Something went wrong!');
       }

       const data = await response.json();
       return data;
   } catch (error) {
    console.log("There was an error processing the response: " + JSON.stringify(error));
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