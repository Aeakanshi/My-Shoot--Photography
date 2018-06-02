/*-----VARIABLES-----*/
body {
  font-family: 'Roboto', sans-serif; }

header .navbar.bg-light {
  background-color: #fa4a6f !important;
  -o-box-shadow: 0px 0px 25px -10px;
  -ms-box-shadow: 0px 0px 25px -10px;
  -moz-box-shadow: 0px 0px 25px -10px;
  -webkit-box-shadow: 0px 0px 25px -10px;
  box-shadow: 0px 0px 25px -10px; }
header .navbar .navbar-brand, header .navbar .nav-item .nav-link {
  color: #ffffff; }

.outer-wrapper {
  /*display: flex;*/
  position: relative;
  margin-top: 54px; }

h1 {
  font-size: 2.5rem;
  line-height: 110%;
  margin: 0 0 1.68rem 0;
  color: #009688; }

.overlay {
  background: rgba(0, 0, 0, 0.15);
  position: absolute;
  height: 100%;
  z-index: 1;
  width: 100%; }

.parallaxContainer {
  width: 100%;
  height: auto;
  display: flex;
  line-height: 0;
  flex-wrap: wrap;
  background-size: cover;
  overflow: hidden;
  min-height: 500px;
  position: relative;
  align-items: center;
  justify-content: center;
  color: rgba(255, 255, 255, 0.9); }
  .parallaxContainer section {
    /*background: rgba(255, 255, 255, 0.41);*/
  			/*box-shadow: $shadow;
			transition: box-shadow .25s;*/ }
    .parallaxContainer section h1 {
      font-size: 48px;
      color: #ffffff;
      /*font-weight: bold;*/
      text-shadow: 1px 1px 4px rgba(0, 0, 0, 0.6); }
  .parallaxContainer ul {
    padding: 0;
    width: 100%;
    display: flex;
    position: relative; }
    .parallaxContainer ul li {
      display: flex;
      justify-content: center; }
  .parallaxContainer .parallax {
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    z-index: -1; }
    .parallaxContainer .parallax img {
      opacity: 0;
      position: absolute;
      left: 50%;
      bottom: 0;
      min-width: 100%;
      min-height: 100%;
      -webkit-transform: translate3d(0, 0, 0);
      transform: translate3d(0, 0, 0);
      -webkit-transform: translateX(-50%);
      transform: translateX(-50%); }

.wrapper {
  /*width: 100%;*/
  /*justify-content: flex-end;*/
  /* align-items: end; */
  /* display: flex;
   flex-wrap: wrap;*/
  position: relative;
  padding: 5rem 0;
  background: #f5f5f5;
  box-shadow: 0 2px 5px 0 rgba(0, 0, 0, 0.16), 0 2px 10px 0 rgba(0, 0, 0, 0.12);
  transition: box-shadow .25s; }

.thumb {
  display: flex;
  justify-content: center; }
  .thumb a {
    /*height: 100%;
    width: 100%;
    padding: 30.0% 0;*/
    /*display: flex;*/
    /* align-items: center;
     justify-content: center;*/
    padding: 4rem;
    background: #009688;
    transition: box-shadow .25s;
    box-shadow: 0 2px 5px 0 rgba(0, 0, 0, 0.16), 0 2px 10px 0 rgba(0, 0, 0, 0.12);
    border-radius: 2px;
    /* background: center/cover no-repeat;
     position: relative;
     text-transform: none;*/ }
    .thumb a img {
      width: 100%; }

.row ul {
  display: flex;
  width: 100%;
  padding: 0; }
  .row ul li {
    width: 33.33333%;
    list-style-type: none;
    display: flex;
    /* align-items: center; */
    justify-content: center; }
    .row ul li a span {
      width: 250px;
      height: 250px;
      padding: 4rem;
      border-radius: 50%;
      background: #009688;
      display: flex;
      flex-wrap: wrap;
      transition: box-shadow .25s;
      box-shadow: 0 2px 5px 0 rgba(0, 0, 0, 0.16), 0 2px 10px 0 rgba(0, 0, 0, 0.12); }
    .row ul li a img {
      width: 100%; }

.wrapper.shoot {
  position: relative; }
  .wrapper.shoot .shoot__type {
    height: 100%;
    display: flex;
    padding-top: 30%;
    -webkit-clip-path: polygon(0% 15%, 15% 15%, 15% 0%, 85% 0%, 85% 15%, 100% 15%, 100% 85%, 85% 85%, 85% 100%, 15% 100%, 15% 85%, 0% 85%);
    clip-path: polygon(0% 15%, 15% 15%, 15% 0%, 85% 0%, 85% 15%, 100% 15%, 100% 85%, 85% 85%, 85% 100%, 15% 100%, 15% 85%, 0% 85%);
    align-items: center;
    justify-content: center;
    transition: box-shadow .25s;
    box-shadow: 0 2px 5px 0 rgba(0, 0, 0, 0.16), 0 2px 10px 0 rgba(0, 0, 0, 0.12);
    border-radius: 2px;
    background: center/cover no-repeat;
    position: relative;
    text-transform: none; }

/*.wrapper.shoot {*/
	/*position: fixed;
	background: #000000;
    right: 0;
    height: 100%;*/
  /*  position: relative;

	a {
		 position: relative;
		 width: (100%/3);*/
/* width: (100% - 5%);*/
/* margin: 7px auto 0 auto;*/
/*.shoot__type {*/
	/*height: 100%;
    display: flex;*/
/*  align-items: center;
  justify-content: center;*/
	/*transition: box-shadow .25s;
	box-shadow: $shadow;
	border-radius: 2px;
    background: center/cover no-repeat;
    position: relative;
    text-transform: none;*/
	/*&:before {
 	    content: '';
	    background:rgba(0,0,0,0.3)*/
/*rgba(255, 250, 251, 0.43)*/
/*rgba(242, 239, 232, 0.5215686274509804)*/
/*rgba(0, 0, 0, 0.47);*/
/*#ff00001c;*/
			  /*  width: 100%;
			    height: 100%;
			    display: block;
			    position: absolute;
			 };
*/
			/* section {
			 	position: absolute;

			 	h2 {
			 		color:$white;*/
/*#ff5aa6;*/
		 	/*}
		 }
	}
}*/
/*}*/
#snow {
  background: none;
  background-image: url("../img/snow/sn1.png"), url("../img/snow/sn2.png"), url("../img/snow/sn3.png");
  height: 100%;
  left: 0;
  position: absolute;
  top: 0;
  width: 100%;
  z-index: 1;
  -webkit-animation: snow 10s linear infinite;
  -moz-animation: snow 10s linear infinite;
  -ms-animation: snow 10s linear infinite;
  animation: snow 10s linear infinite; }

@keyframes snow {
  0% {
    background-position: 0px 0px, 0px 0px, 0px 0px; }
  50% {
    background-position: 500px 500px, 100px 200px, -100px 150px; }
  100% {
    background-position: 500px 1000px, 200px 400px, -100px 300px; } }
@-moz-keyframes snow {
  0% {
    background-position: 0px 0px, 0px 0px, 0px 0px; }
  50% {
    background-position: 500px 500px, 100px 200px, -100px 150px; }
  100% {
    background-position: 400px 1000px, 200px 400px, 100px 300px; } }
@-webkit-keyframes snow {
  0% {
    background-position: 0px 0px, 0px 0px, 0px 0px; }
  50% {
    background-position: 500px 500px, 100px 200px, -100px 150px; }
  100% {
    background-position: 500px 1000px, 200px 400px, -100px 300px; } }
@-ms-keyframes snow {
  0% {
    background-position: 0px 0px, 0px 0px, 0px 0px; }
  50% {
    background-position: 500px 500px, 100px 200px, -100px 150px; }
  100% {
    background-position: 500px 1000px, 200px 400px, -100px 300px; } }

/*# sourceMappingURL=global.cs.map */
