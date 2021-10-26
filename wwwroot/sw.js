self.addEventListener("instal", e => {
    e.waitUntil(
        caches.open("static").then(cache => {
            return cache.addAll([
                "./",
                "./css/onlystyle.min.css",
                "./img/icons/ios/192.png"
            ]);
        })
    );
});

self.addEventListener("fetch", e => {
    console.log('Fetch request for: ' + e.request.url);
    e.respondWith(
        caches.match(e.request).then(response => {
            return response || fetch(e.request);
        })
    );
});