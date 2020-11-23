let tags;
$.get("/Home/GetTags", function (data) {
    let tags = new Set(data);
    tagify.settings.whitelist.splice(0, tags.length, ...tags);
    tagify.loading(false).dropdown.show.call(tagify, tags);
})

$("#tags").on("DOMNodeInserted", function (event) {
    let arr = "";
    $(".tagify__tag").each(function () {
        arr += "#";
        arr += (this.getAttribute("title"));
    })
});

let input = document.querySelector('input[name="Tags"]'),
    tagify = new Tagify(input, {
        whitelist: [],
        maxTags: 10,
        dropdown: {
            maxItems: 20,
            classname: "tags-look",
            enabled: 0,
            closeOnSelect: false
        }
    })