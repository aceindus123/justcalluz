var touchy=(navigator.userAgent).indexOf("CPU OS 5_0") == -1 && ('ontouchstart' in document.documentElement)? true : false;
var path = 'http://images.jdmagicbox.com/jcontent/';

function getBlockDivScroll()
{
    if (touchy == true && stat == true) 
	{
        var topBlock = $(window).scrollTop()+40;
        $('.blockMsg').animate({top:topBlock+'px'},'fast');
        if($('.feedbckbtn').hasClass('feedbckbtn')) 
		{
            $('.feedbckbtn').animate({top:($(window).scrollTop()+$(window).height()-100)+'px'},'fast');
        }
    }
}

function getScrollTop() 
{
    if (window.pageYOffset != null) 
	{
        var _pageScrollTop = window.pageYOffset;
    } 
	else 
	{
        var _pageScrollTop = document.body.scrollTop ? document.body.scrollTop : document.documentElement.scrollTop ;
    }
    
	return _pageScrollTop;
}

function div_open(divname) 
{
	divpop = divname;
	var wintop = getScrollTop();var winwidth = $(window).width();var winheight = $(window).height();var offset = $('body').offset();
	var divwidth = $('#'+divname).width();var divheight = $('#'+divname).height();var startwidth = (winwidth-divwidth)/2;
	var startheight = (winheight-divheight)/2;
	$.blockUI.defaults.css = {};
	$.blockUI({ message: $('#'+divname),
		css: {left:	Math.ceil(startwidth)+'px',	top: Math.ceil(startheight)+'px', padding: 0, margin: 0, backgroundColor: '#fff', cursor: 'default'}
	})
}

function div_close(divname) 
{
	$.unblockUI();
}

function Gallery(id)
{		
	var imgpath = '';

	imgpath = path + 'cmscsr' + id + '.jpg';
	
	if(id == 0)
	{
		$('#imgblueright').removeClass("blackgreyright");
		
		$('#imggreyleft').removeClass("blackblueleft");
		$('#imggreyleft').addClass("blackgreyleft");
	}
	else if(id == totImg - 1)
	{
		$('#imggreyleft').addClass("blackblueleft");
		$('#imgblueright').addClass("blackgreyright");
	}
	else
	{
		$('#imgblueright').removeClass("blackgreyright");
		$('#imggreyleft').addClass("blackblueleft");
	}
	
	/*
	$('#b' + id + ' > a').html('<img src="' + imgpath + '" />');
	
	if(prev != id)
	{
		$('#b' + prev).hide();
		$('#b' + id).show();
	}
	else
	{
		$('#b' + prev).show();
	}

	prev = id;
	*/
	
	for(i=0;i<totImg;i++)
	{
		//(id == i) ? $('#b'+ i + ' > a > img').attr('src',imgpath) : '';
		(id == i) ? $('#b' + i + ' > a').html('<img src="' + imgpath + '" />') : '';
		(id == i) ? $('#b' + i).show() : $('#b' + i).hide();		
	}
	

	//$('#imageview').show();
	div_open('imageview');
	
	//return false;
}

function getImg(action)
{
	var x = '';
	var y = '';	
	var idnum = '';
	
	var imgcnt = $("#showimg > div").size();
	
	$("#showimg div").each(function()
	{
		if ($(this).is(':visible') == true)
		{
			$(this).attr("style","display:none");

			if (action == "next")
			{

				var obj = $(this).next();
	
				if($(obj).html()!=null)
				{
					//alert($(obj).attr("id"));
					x = $(obj).attr("id").split('b');

					imgpath	= path + 'cmscsr' + x[1] + '.jpg';

					//$('#' + $(obj).attr("id") + ' > a > img').attr('src',imgpath);
					$('#' + $(obj).attr("id") + ' > a').html('<img src="' + imgpath + '" />');
					
					
					$('#imggreyleft').addClass("blackblueleft");
					$(obj).attr("style","display:block");
				}
				else
				{
					$(this).attr("style","display:block");
				}
				
				if($(obj).html()!=null)
				{
					y = $(obj).attr("id").split('b');
					idnum = y[1];
					
					if(idnum < imgcnt - 1)
					{
						$('#imgblueright').removeClass("blackgreyright");
					}
					else
					{
						$('#imgblueright').addClass("blackgreyright");
					}
				}
			
			}
			else
			{
				var obj = $(this).prev();

				if($(obj).html()!=null)
				{
					x = $(obj).attr("id").split('b');
				
					imgpath	= path + 'cmscsr' + x[1] + '.jpg';

					//$('#' + $(obj).attr("id") + ' > a > img').attr('src',imgpath);
					$('#' + $(obj).attr("id") + ' > a').html('<img src="' + imgpath + '" />');
					
					
					$('#imgblueright').removeClass("blackgreyright");
					$(obj).attr("style","display:block");
				}
				else
				{
					$(this).attr("style","display:block");
				}
				
				if($(obj).html()!=null)
				{
					y = $(obj).attr("id").split('b');
					idnum = y[1];

					if(idnum != 0)
					{
						$('#imgblueright').removeClass("blackgreyright");
					}
					else
					{
						$('#imggreyleft').removeClass("blackblueleft");
					}
				}
		
			}
			
			return false;
		}
	});

}

function css_browser_selector(u)
{
	var ua=u.toLowerCase(),is=function(t){return ua.indexOf(t)>-1},m='mobile', w='webkit', g='gecko', h=document.documentElement,b=[(!(/opera|webtv/i.test(ua))&&/msie\s(\d)/.test(ua))?('ie	 ie'+RegExp.$1) : is('ipad') ? m + ' ipad' : is('chrome') ? w + ' chr' : is('safari') ? w + ' saf' : is('opera') ? w + ' opr' : is('firefox') ? g + ' ffox' : '','js'];
        c = b.join(' ');
        h.className += ' '+c;
        return c;
};
css_browser_selector(navigator.userAgent);


/*Winner page floating header*/
function fltdiv()
{
    var top = $(window).scrollTop();
	var Topheight = $(".slideshowmiddle").offset().top+$(".slideshowmiddle").height();

    if (top >= Topheight)
	{
        $('#containdiv').attr("style","position:fixed;top:0px;");
		$('.border').attr("style","border-bottom:1px dotted #D3CFCF");
    }
	else
	{
	    $('#containdiv').attr("style","top:0px");
		$('.border').removeAttr("style");
	}
}

window.onscroll = function ()
{
	
		if($.browser.msie)
		{
			if(($.browser.version!="6.0" && $.browser.version!="7.0"))
			{
				fltdiv();
			}
		}
		else
		{
			fltdiv();
		}
		if(navigator.userAgent.match(/iPad/i))
		{	
			changeFooterPosition();	
		}	
	
}
/*Winner page floating header*/

/*Winner page ipad handling for view gallery*/

function changeFooterPosition() 
{   
	if (window.innerWidth > window.innerHeight) 
	{
            //alert("landscape [ ]");
		if(navigator.userAgent.match(/8L1/i))
		{				
            document.getElementById('imageview').style.top =
            (window.pageYOffset + (window.innerHeight/2) - 250) + 'px';
		}
		else
		{
			document.getElementById('imageview').style.top =
            '0px';
        }
	}
    if (window.innerHeight > window.innerWidth) 
	{
		if(navigator.userAgent.match(/8L1/i))
		{	
			document.getElementById('imageview').style.top =
		   (window.pageYOffset + (window.innerHeight/2)- 550) + 'px';
		}
		else
		{
		document.getElementById('imageview').style.top ='0px';
		}
	}
}
