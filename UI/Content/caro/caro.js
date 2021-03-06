﻿!(function () { 
    // hasElement
    function hasElement(ele) {
        return (ele[0] || ele).nodeType;
    }

    // stopBubble
    function stopBubble(ev) {
        ev = ev || window.event;
        ev.cancelBubble = true;
    }

    function caroPlay() {
        var caro = document.getElementsByClassName('soso-caro');

        // 判断当前页面是否有轮播元素
        if (!hasElement(caro)) {
            return;
        }

        var caroItem = caro[0].getElementsByClassName('item');
        // var caroItem  = caro[0].getElementsByTagName('div');
        var caroCtrls = document.getElementsByClassName('caro-ctrl');
        var caroIndex = document.getElementsByClassName('caro-index')[0].getElementsByClassName('index');
        var curent = 0;

        // 淡入
        function fadeIn() {
            caroItem[curent].classList.add('active');
            caroIndex[curent].classList.add('active');
        }
        // 淡出
        function fadeOut() {
            caroItem[curent].classList.remove('active');
            caroIndex[curent].classList.remove('active');
        }

        // 前进
        function go() {
            fadeOut();

            curent++;
            if (curent >= caroItem.length) {
                curent = 0;
            }

            fadeIn();
        }

        // 返回
        function bk() {
            fadeOut();

            if (curent == 0) {
                curent = caroItem.length;
            }
            curent--;

            fadeIn();
        }

        var inter = setInterval(go, 4000);

        // 鼠标移入
        caro[0].onmouseover = function (ev) {
            stopBubble(ev)

            clearInterval(inter);

            for (var i = caroCtrls.length - 1; i >= 0; i--) {
                caroCtrls[i].style.display = 'block';
            }
        };

        // 鼠标移出
        caro[0].onmouseout = function (ev) {
            stopBubble(ev);

            inter = setInterval(go, 2000);

            for (var i = caroCtrls.length - 1; i >= 0; i--) {
                caroCtrls[i].style.display = 'none';
            }
        };

        caroCtrls[0].onclick = function (ev) {
            stopBubble(ev);
            bk();
        };

        caroCtrls[1].onclick = function (ev) {
            stopBubble(ev);
            go();
        };
    }

    caroPlay();
}());
