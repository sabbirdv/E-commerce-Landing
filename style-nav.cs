*{
    box-sizing: border-box;
    margin: 0px;
    padding: 0px;
    font-family: var(--font);
 }
 :root{
    --dark: #101828 ;
    --normal: #4A5565;
    --nav-link: #364153;
    --font: Arimo
 }
 .width{
    max-width: 1400px;
 }
 .navbar .navbar-nav .p-16{
   padding: 0px 16px;
 }
 nav{
    height: 80px;
    width: 100vw;
    border-bottom: 1px solid rgba(0, 0, 0, 0.05);
    background: rgba(255, 255, 255, 0.8);
    backdrop-filter: blur(15px);
 }
 nav .navbar-brand h1{
    font-size: 17px;
    margin: 0 0 0 10px;
 }
.navbar .navbar-brand h1{
   color: var(--dark);
}
.navbar .nav-link{
   color: var(--nav-link);
   font-size: 14px;
   font-weight: 400;
   line-height: 150%;
}
.navbar .nav-btns{
   list-style-type: none;
   padding: 8px;
   gap: 8px;
   width: 200px;
}
 .nav-btn{
   display: flex;
   justify-content: center;
   align-items: center;
 }
 .nav-btn .nav-btn-link{
    height:40px ;
    width: 40px;
    display: flex;
    justify-content: center;
    align-items: center;
    border-radius: 10px;
 }
  .nav-btns .nav-btn-link:hover{
    
    background-color: rgba(212, 212, 212, 0.212);
  }
   .nav-btns span{
    height: 16px;
    width: 16px;
    top: 0px;
    right: -5px;
    color: white;
    font-size: 10px;
    font-weight: 700;
    background: var(--dark);
 }
 .hero{
   padding-top: 160px;
 }
 .test .div-1 , .test .div-2 {
   height: 200px;
   width: 200px;
 }
 nav .container-fluid{
    display: flex;
    justify-content: space-between;
 }