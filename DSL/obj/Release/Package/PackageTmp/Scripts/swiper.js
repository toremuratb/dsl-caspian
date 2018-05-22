$(window).load(function(){
    // Swiper Clients
    var swiper = new Swiper('.swiper-clients', {
        speed: 1000,
        autoplay: 5000,
        slidesPerView: 5,
        spaceBetween: 50,
        loop: true,
        breakpoints: {
            1024: {
                slidesPerView: 4,
                spaceBetween: 50
            },
            992: {
                slidesPerView: 3,
                spaceBetween: 40
            },
            768: {
                slidesPerView: 3,
                spaceBetween: 30
            },
            600: {
                slidesPerView: 2,
                spaceBetween: 30
            },
            480: {
                slidesPerView: 1,
                spaceBetween: 0
            }
        }
    });

    // Swiper Clients
    var swiper = new Swiper('.swiper-testimonials', {
        speed: 1000,
        autoplay: 10000,
        slidesPerView: 1,
        loop: true,
    });

    // Swiper Projects
    var swiper = new Swiper('.swiper-projects', {
        speed: 1000,
        autoplay: 8000,
        slidesPerView: 3,
        spaceBetween: 50,
        loop: true,
        pagination: '.swiper-pagination',
        paginationHide: false,
        paginationClickable: true,
        nextButton: '.swiper-button-next',
        prevButton: '.swiper-button-prev',
        breakpoints: {
            1024: {
                slidesPerView: 3,
                spaceBetween: 50
            },
            992: {
                slidesPerView: 2,
                spaceBetween: 40
            },
            768: {
                slidesPerView: 2,
                spaceBetween: 30
            },
            600: {
                slidesPerView: 1,
                spaceBetween: 30
            },
            480: {
                slidesPerView: 1,
                spaceBetween: 0
            }
        }
    });
});
