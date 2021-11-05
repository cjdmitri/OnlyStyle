let settings={
    tags:"h2, h3, h4, h5, h6",
    pagenavigatorid:"pagenavigator",
    generateid:false,
    generatename:"header"
}

document.addEventListener('DOMContentLoaded', startup());



function startup() {
    console.info(settings.pagenavigatorid);
    let pagenavigator = document.getElementById(settings.pagenavigatorid);
    //Проверяем наличие контейнера для оглавления
    if (pagenavigator === null) {
        console.info('No container PageNavigatorJS');
        return;
    }
    let headersTags = document.querySelectorAll(settings.tags);

    //если нет заголовков, то выходим
    if (headersTags.length === 0) {
        pagenavigator.style.display = 'hidden';
        return;
    }

    //Если необходимо генерировать ид
    if(settings.generateid){
        headersTags.forEach(function (item, i){
            if(item.id===""){
                let id = `${settings.generatename}${i}`;
                item.id=id;
                console.log(id);
            }
        });
    }
    

    //необходима для определения вложенности списка
    let lastNumberTag;
    let content = '<ul>';
    
    headersTags.forEach(function (item, i, headersTags) {
        if (item.id !== "") {
            console.log(i);
            let hNumber = parseInt(item.tagName.slice(1));
            if (i == 1) {
                content += appendItem(item.id, item.innerHTML);
            }
            else {
                //Если заголовок равен прошлому заголовку, то создаём элемент списка
                if (lastNumberTag === hNumber) {
                    content += appendItem(item.id, item.innerHTML);
                }
                //Если номер тега больше прошлого, то создаём вложеный список
                else if (hNumber > lastNumberTag) {
                    let nesting = hNumber-lastNumberTag;
                    for(let r=0;r<nesting; r++){
                        content += '<li><ul>';
                    }
                    content += appendItem(item.id, item.innerHTML);

                }
                else if (hNumber < lastNumberTag) {
                    for (let r = 0; r < lastNumberTag - hNumber; r++) {
                        content += '</ul></li>';
                    }
                    content += appendItem(item.id, item.innerHTML);
                }
            }
            lastNumberTag = hNumber;
        }
        else {
        }
    });
    //Append root list on page
    content += '</ul>';
    pagenavigator.innerHTML += content;
}


function appendItem(id, title){
    return  `<li><a href="#${id}">${title}</a></li>`;
}