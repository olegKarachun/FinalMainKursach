function Editor(input, preview) {
    this.update = function () {
        preview.innerHTML = markdown.toHTML(input.value);
    };
    input.editor = this;
    this.update();
}

let getElement = function (id) { return document.getElementById(id); };
new Editor(getElement("inputContent"), getElement("preview"));


let dropArea = document.getElementById('drop-area');
let image;

['dragenter', 'dragover', 'dragleave', 'drop'].forEach(eventName => {
    dropArea.addEventListener(eventName, preventDefaults, false)
});

function preventDefaults(e) {
    e.preventDefault();
    e.stopPropagation();
}

['dragenter', 'dragover'].forEach(eventName => {
    dropArea.addEventListener(eventName, highlight, false)
});

['dragleave', 'drop'].forEach(eventName => {
    dropArea.addEventListener(eventName, unhighlight, false)
});

function highlight(e) {
    dropArea.classList.add('highlight');
}

function unhighlight(e) {
    dropArea.classList.remove('highlight');
}

dropArea.addEventListener('drop', handleDrop, false);

function handleDrop(e) {
    let dt = e.dataTransfer;
    let files = dt.files;
    handleFiles(files);
}

function handleFiles(files) {
    image = files[0];
    previewFile(image);
}

function previewFile(file) {
    let reader = new FileReader()
    reader.readAsDataURL(file)
    reader.onloadend = function () {
        let img = document.getElementById('img')
        img.src = reader.result
    }
}
