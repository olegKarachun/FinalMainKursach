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