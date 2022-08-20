//const fs = require('fs');
// its hard to write/read from file w/o node :(
const sendButton = document.querySelector("#new-post-button");
const allPosts = document.querySelector("#history-wrapper");
const newPostText = document.querySelector("#new-post-textarea");

function LoadAboutPost() {
    const newPost = document.createElement('div');
    newPost.id = "old-post";
    newPost.className = "old-post";

    const newPostTextArea = document.createElement('textarea');
    newPostTextArea.id = "old-post-textarea";
    newPostTextArea.className = "old-post-textarea";
    newPostTextArea.value = "Greetings, traveler!\nI'm Oleksandr Nahlenko, and i'm a student of this course.\nAnd\ni am trying\nmake some cool shit";
    newPostTextArea.readOnly = true;
    newPostTextArea.style.height = 17*newPostTextArea.value.split("\n").length + "px";

    newPost.appendChild(newPostTextArea);
    allPosts.appendChild(newPost);
}

function AutoGrow(element) {
    element.style.height = "40px";
    element.style.height = (element.scrollHeight)+"px";
}

sendButton.addEventListener('click', ()=>{
    const newPost = document.createElement('div');
    newPost.id = "old-post";
    newPost.className = "old-post";

    const newPostTextArea = document.createElement('textarea');
    newPostTextArea.id = "old-post-textarea";
    newPostTextArea.className = "old-post-textarea";
    newPostTextArea.value = newPostText.value;
    newPostTextArea.readOnly = true;
    newPostTextArea.style.height = 17*newPostTextArea.value.split("\n").length + "px";

    newPost.appendChild(newPostTextArea);
    allPosts.appendChild(newPost);

    newPostText.style.height ="40px";
    newPostText.value = "";
});