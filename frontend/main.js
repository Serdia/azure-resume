
// this funtion is responsible for counting how many times your resume was viewed

// this is how this function get called
// basically saying when DOMContentLoaded is loaded go and run this event
window.addEventListener('DOMContentLoaded', (event) =>{
    getVisitCount();
})

const functionApiUrl = 'https://fngetresumecounter.azurewebsites.net/api/GetResumeCounter?code=kF_5fxYe7odSnUW1539r1zms9xfmNDKdMQ4eMOVIeo2QAzFu9aUbEQ=='
const localFunctionApi = 'http://localhost:7071/api/GetResumeCounter';

const getVisitCount = () => {
    let count = 30;
    // fetch call means go get the data that provided in link of functionApi above
    fetch(functionApiUrl).then(response => {
        return response.json()
        // then grab that response and log a quick message for debugging
    }).then(response =>{
        console.log("Website called function API.");
        //set this variable to the actual data that is in json response
        count = response.count;
        // go to a document that has element that has counter as by ID, grab inner text and set it as a count.
        document.getElementById("counter").innerText = count;
    }).catch(function(error){
        console.log(error); // if there is an error we need to log it to a console
    });
    return count;
}