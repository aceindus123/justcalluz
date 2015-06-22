var date = new Date();
date.setTime(date.getTime()+(30*24*60*60*1000));
var validcity = 0;
var whatid="",JSONObject = null;var citydiv="#city_Suggest_Main";var cachearr = new Array();var url = location.href;
var casesCity  = 'city'
var casesWhat  = 'what'
var casesWhere = 'where'
var casesStdcode = 'stdcode'
if(url.indexOf('jdsoftware.com') >= 0) {
	var cookieondomain = '.jdsoftware.com';
}
else {
	var cookieondomain = '.justdial.com';
}
String.prototype.autovalue = function(id){
    if (onloadFn == "contest" && this=="what")
    {
       return 'whatcontest';
    }
	else if (onloadFn == "customercare" && this=="what")
    {//harshada
       return 'customercare';
    }//harshada
	else if (id == "#what" && onloadFn == "contest")
	{
		if (this.trim()=="")
			return  " ";
		else
			return String(this.replace(/\'/gi,"")+"!ct!0!ct!"+$("#gender").val());	
		
	}
    return String(this.replace(/\'/gi,""));
 };

Autosuggest = function() {
	$('#city').click(function(event){
		JSON("ajxmain.php",{cases: casesCity.autovalue(),search: '@A@'+'' },'#city_Suggest_Main');
	});
	$('#city,#flcity,#liscity').keyup(function(event) {
		if(this.id=="flcity")
            citydiv = "#city_Suggest_Sub";
		else if(this.id=="liscity")
			citydiv	= "#city_Suggest_Sub_lis";
		else
            citydiv = "#city_Suggest_Main";
		 if (handleKeys(event,"#"+this.id,"#what",citydiv)==true) return false;
		 JSON("ajxmain.php",{cases: casesCity.autovalue(),search: $("#"+this.id).val().trim()+'' },citydiv);
 	});

	$('#city,#what,#where').focus(function(event){
		if($("#" + this.id).hasClass("greyColor") || this.id=="city") {

			/*if(this.id=='what' && $("#city").val() != 'National Search')
			{
				$.ajax({url:WEBROOT+"ajxmain.php?city="+$("#city").val()+"&cases=citycheck",async:false, success:function(result){
				if(result=="City Failed")
				{
					validcity = 1;
				}
				else
				{
					validcity = 0;
				}}});
			}*/

			if($("#" + this.id).val()!="")$("#" + this.id).attr("alt",$("#" + this.id).val());
			$("#" + this.id).val("");
		}
		/*else
		{
			if(this.id=='what' && $("#city").val() != 'National Search')
			{
				$.ajax({url:WEBROOT+"ajxmain.php?city="+$("#city").val()+"&cases=citycheck",async:false, success:function(result){
				if(result=="City Failed")
				{
					validcity = 2;
				}
				else
				{
					validcity = 0;
				}}});
			}
		}*/
		if (this.id!="city") $("#" + this.id).removeClass("greyColor");
		if(this.id=='what' && valcheck == 1)
		{
			alert("Please Select Valid City");
			$("#city").focus();
			$("#" + this.id).addClass("greyColor");
			JSON("ajxmain.php",{cases: casesCity.autovalue(),search: '@A@'+'' },'#city_Suggest_Main');
		}
		else if(this.id=='what' && valcheck == 2)
		{
			alert("Please Select Valid City");
			$("#city").focus();
			JSON("ajxmain.php",{cases: casesCity.autovalue(),search: '@A@'+'' },'#city_Suggest_Main');
		}
	});
	$('#what,#where').keyup(function(event) {
		if(onloadFn=="National Search")	{
			if(event.which == 13) {
				gofun();
			}
			return false;
		}
		if ($("#"+this.id).val().substr(0,4)=="e.g." || $("#"+this.id).val()=="" && this.id == "what") {
			divHide("","");
			return false;
		}
		if (this.id=="what") 
		{
 			whatid="";
			if(event.which==39 || event.which==37) return;
			if (handleKeys(event,"#what","#where","#comp_cat_Suggest_Main")==true)
				return false;
			/*if(!cachearr[$('#city').val().toUpperCase()+' '+$('#what').val().toUpperCase().autovalue()])
			{*/
		        var str = $('#what').val().trimSpace().autovalue("#what");
				str = str.replace(/[[\]{}()*+?.,\\^$|#]+/g,'');
				str = str.replace(/\-/g,' ');
				str = str.replace(/[\s+]+/g,' ');

				if(str != " ")
            	{
                    JSON("ajxmain.php",{cases:  casesWhat.autovalue(),search:  ''+str+'' ,city:  ''+ $('#city').val()+''},'#comp_cat_Suggest_Main');
                }
            /*}
			else
            {
				JSONcache(cachearr[$('#city').val().toUpperCase()+' '+$('#what').val().trim().toUpperCase()],{search:  ''+$('#what').val().trim()+'' ,city:  ''+ $('#city').val()+'' ,cases:  casesWhat.autovalue()},'#comp_cat_Suggest_Main');
            }*/
		}
		else {
			if (handleKeys(event,"#where","","#area_Suggest_Main")==true) return false;
			
			var str = $('#where').val().trim();
			str = str.replace(/[[\]{}()*+?.,\\^$|#]+/g,'');
			str = str.replace(/\-/g,' ');
			str = str.replace(/\'/g,'');
			str = str.replace(/[\s+]+/g,' ');
			
			var str1 = str.substr(0,4);
			var str2 = str.substr(0,5);
			
			if(str1.toLowerCase() != "near" || str2.toLowerCase() == "near ")
			{
			JSON("ajxmain.php",{cases:  casesWhere.autovalue(),search:  ''+str+'' ,city:  ''+ $('#city').val()+''},'#area_Suggest_Main');
			}
			
		}
	});
	$('#verifycodeval').keypress(function(event) {
		//alert(event.which); //harshada
		if(event.which == 13) {
				testing();
				return false;
			}			
	});
	$('#what,#where').keydown(function(event) {
		if (event.which != 9) {
			$("#"+this.id).focus();
		}
		else if (event.which == 9) {
			if (JSONObject != null)	JSONObject.abort();
			if (this.id=="what") {
				whatid=$("#comp_cat_Suggest_Main ul li a.active").attr("id");
				if (whatid!=undefined) {
					 setData("#"+this.id,$("#comp_cat_Suggest_Main ul li a.active").text().replace(' [+]',''));
				}
			}
			else {
				setData("#"+this.id,$("#area_Suggest_Main ul li a.active").text());
			}
			divHide('','');
		}
 	});
	$('#area_Suggest_Main,#comp_cat_Suggest_Main,#city_Suggest_Main').mouseover(function(event){$("#" + this.id + " ul li a").removeClass("active");});
	$('.dar,.darsub').mouseup(function(event){
        if($(this).hasClass('darsub')==true) {
            citydiv = "#city_Suggest_Sub";  $("#city_Suggest_Main").html(""); }
        else {
            citydiv = "#city_Suggest_Main"; $("#city_Suggest_Sub").html(""); }
    	if($(citydiv).is(":visible")==false) {
			$.get(WEBROOT + "template/city_div.php",{city:$('#city').val()}, function(data) {
                $(citydiv).html(data);
				$(citydiv).addClass("autosuggest_divCityDiv");
				$(citydiv).removeClass("city_Suggest_MainWdth");
			});
		}
		$(citydiv).toggle();
	});
	$('#go').click(function(event){gofun();});
};
var divHide = function(Nextobject,divHolder) {
	$(".autosuggest_div").hide();
	$(Nextobject).focus();
}
function setData(object,data) {

	valcheck = 0;
	if (object == "#city" && data == "") {
        data = autoValue;
    }
    if (data) {
			autoValue=data;
			$(object).val(data);
			if(object == '#flcity')
			{
				$.get(WEBROOT + "ajxmain.php",{cases:  casesStdcode,city:  ''+ data+''}, function(data) {
					$(".std").val(data);
				});
			}
	}
    if (object == "#city" && data != "") {
		document.cookie = 'inweb_area=; '+date+'; path=/; domain=' + cookieondomain;
		document.cookie = 'inweb_city='+$("#city").val().trim()+'; '+date+'; path=/; domain=' + cookieondomain;
		if (data.length >= 12)
			$("#wherein").html(" in "+data.substr(0,12)+"..."+"?");
		else
			$("#wherein").html(" in "+data+"?");
		$("#chkrembercity").removeAttr('checked');
		if(onloadFn=="National Search") window.location = WEBROOT;
	}
	if (object == "#where" && $("#what").hasClass("greyColor")) {
		fn_Banner();
	}
}
var handleKeys = function(evt,object,Nextobject,divHolder,divSelection) {

	if (!divSelection) divSelection = $(divHolder + " ul li a.active");
	if (typeof evt.length == "number")
		keyCode = evt.split("-")[1];
	else
		keyCode = evt.which;
	if (keyCode == 13) {
		if (object == "#what") whatid = $(divSelection).attr("id");
		setData(object,$(divSelection).text().replace(' [+]',''));
        divHide(Nextobject,divHolder);
		if(whatid != undefined && object == "#what") 
		{
			//##	CONDITION HANDLED TO REDIRECT B2B AND ALL AREA CATEGORY TO RE-DIRECT TO ITS LISTING PAGE	
			//##	FORMAT  catid-type-aflg(area not mandatory flag)  Ex. 157784-1-1
			//##	SO IF type=1 AND aflg=1 THEN REDIRECT TO ITS CATEGORY LISTING PAGE

			var tmp = whatid.split('-');
			if(tmp[1]==1 && tmp[2]==0){
				return true;
			}
			else
				gofun();
		}
		else if (object == "#city" && onloadFn=="National Search") {
			document.cookie = 'inweb_city='+$("#city").val().trim()+'; '+date+'; path=/; domain=' + cookieondomain;
			window.location = WEBROOT;
			return false;
		}
		else if (object == "#where" || onloadFn=="National Search") {
			gofun();
		}
		return true;
	} else if (keyCode == 38 || keyCode == 40) {
		var li_Index="-1";
		$(divHolder+' ul li a').each(function(index,data) {
			if($(data).hasClass("active")==true) {
				li_Index = index;
			}
		});
		if(keyCode == 38 && li_Index == "-1")  // 38 = KeyUp
			li_Index = $(divHolder+' ul li a').length;
		if (keyCode == 38) {
			if (li_Index==0)
				li_Index = $(divHolder+' ul li a').length-1;
			else
				li_Index--;
		} else {
			if (($(divHolder+' ul li a').length-1)==li_Index)
				li_Index = 0;
			else
				li_Index++;
		}
		$(divHolder+' ul li a').each(function(index,data) {
			if (index  == li_Index) {
				autoValue = $(this).text().replace(' [+]','');
				if(object == "#what") whatid = $(this).attr("id").replace(' [+]','');
				$(this).addClass("active");
			}
			else
				$(this).removeClass("active");
		});
			return true;
	 }
	 else {
		 return false;
	 }
};
JSON = function(URL,parameter,divHolder) {
	
	if (JSONObject != null)	JSONObject.abort();
	if(auto == true) {
            clearTimeout(timeauto);
            timeauto = setTimeout('timout()',100);
            timeoutURL=URL;
            timeoutparameter=parameter;
            timeoutdivHolder=divHolder;
            return false;
        }
     auto = true;
    JSONObject = $.getJSON(WEBROOT + URL, parameter, function(data) {
		if(parameter['cases'] == "what") {
			cachearr[parameter['city'].toUpperCase()+' '+parameter['search'].toUpperCase()] = data;
		}
		if(data == null) {
			divHide('',divHolder);
			return false;
		}
		if(data.results == null) {
			divHide('',divHolder);
			return false;
		}
		if(data == undefined || data.results == null) {
			divHide('',divHolder);
			return false;
		}
		if(!data.results.length){
			divHide('',divHolder);
			return false;
		}
		
		(divHolder == '#city_Suggest_Sub_lis' && data.results.length > 4) ? $('select').hide() : $('select').show(); //IE 6
		
		var autoData = '<ul>';
		if(parameter['search'] != "@A@" && parameter['cases'] != "what"  && parameter['cases'] != "where")
			autoValue = data.results[0]['text'];

		var rate = '';
		$.each(data.results, function(i,obj) 
		{
			if(obj['rate']!=null)
				rate = addRating(obj['rate']);
			if(rate)
			{
				autoData += "<li><a id='"+obj['id']+"-"+obj['type']+"-"+(obj['aflg']?obj['aflg']:0)+"' href='javascript:void(0);'>"+ obj['value'] + rate + (obj['info']? " "+obj['info']:'')+ "</a></li>";
			}
			else
			{
				autoData += "<li><a id='"+obj['id']+"-"+obj['type']+"-"+(obj['aflg']?obj['aflg']:0)+"' href='javascript:void(0);'>"+ obj['value'] + (obj['info']? " "+obj['info']:'')+ "</a></li>";
			}
		});
		autoData += "</ul>";

		$(divHolder).html(autoData);
		if(divHolder=="#city_Suggest_Main")
			$('#city_Suggest_Main ul li a').mousedown(function(e){setData("#city",$(this).text());});
		else if(divHolder=="#city_Suggest_Sub")
			$('#city_Suggest_Sub ul li a').mousedown(function(e){setData("#flcity",$(this).text());divHide("","");});
		else if(divHolder=="#city_Suggest_Sub_lis")
			$('#city_Suggest_Sub_lis ul	li a').mousedown(function(e){setData("#liscity",$(this).text());divHide("","");});
		else if(divHolder=="#comp_cat_Suggest_Main")
			$('#comp_cat_Suggest_Main ul li a').mousedown(function(event){handleKeys("key-13","#what","#where","#comp_cat_Suggest_Main",this);return false;});
		else if(divHolder=="#area_Suggest_Main")
			$('#area_Suggest_Main ul li a').mousedown(function(event){handleKeys("key-13","#where","#go","#area_Suggest_Main",this)});
		else if(divHolder=="#autosortDist")
			$('#autosortDist ul li a').mousedown(function(event){handleKeys("key-13","#sortbydist","#go","#autosortDist",this)});
		if(divHolder=="#city_Suggest_Main")
			$("#city_Suggest_Main").addClass("city_Suggest_MainWdth");
		$("#city_Suggest_Main").removeClass("autosuggest_divCityDiv");
		if(divHolder=="#city_Suggest_Sub")
			$("#city_Suggest_Sub").addClass("city_Suggest_MainWdth");
		if(divHolder=="#city_Suggest_Sub_lis")
			$("#city_Suggest_Sub_lis").addClass("city_Suggest_MainWdth");
		$("#city_Suggest_Sub").removeClass("autosuggest_divCityDiv");
		$("#city_Suggest_Sub_lis").removeClass("autosuggest_divCityDiv");
		$(divHolder).show();
	});
}
JSONcache = function(data,parameter,divHolder) {
		if (JSONObject != null)	JSONObject.abort();
		if(data.results == null) {
			divHide('',divHolder);
			return false;
		}
		if(data == undefined) {
			divHide('',divHolder);
			return false;
		}
		if(!data.results.length){
			divHide('',divHolder);
			return false;
		}
		var autoData = '<ul>';
		if(parameter['search'] != "@A@" && parameter['cases'] != "what"  && parameter['cases'] != "where")
			autoValue = data.results[0]['text'];
		$.each(data.results, function(i,obj) {
			autoData += "<li><a id='"+obj['id']+"-"+obj['type']+"' href='javascript:void(0);'>"+ obj['value'] + (obj['info']? " "+obj['info']:'')+ "</a></li>";
		});
		autoData += "</ul>";
		$(divHolder).html(autoData);
		if(divHolder=="#city_Suggest_Main")
			$('#city_Suggest_Main ul li a').mousedown(function(e){setData("#city",$(this).text());});
		else if(divHolder=="#city_Suggest_Sub")
			$('#city_Suggest_Sub ul li a').mousedown(function(e){setData("#flcity",$(this).text());divHide("","");});
		else if(divHolder=="#city_Suggest_Sub_lis")
			$('#city_Suggest_Sub_lis ul	li a').mousedown(function(e){setData("#liscity",$(this).text());divHide("","");});
		else if(divHolder=="#comp_cat_Suggest_Main")
			$('#comp_cat_Suggest_Main ul li a').mousedown(function(event){handleKeys("key-13","#what","#where","#comp_cat_Suggest_Main",this);return false;});
		else if(divHolder=="#area_Suggest_Main")
			$('#area_Suggest_Main ul li a').mousedown(function(event){handleKeys("key-13","#where","#go","#area_Suggest_Main",this)});
		else if(divHolder=="#autosortDist")
			$('#autosortDist ul li a').mousedown(function(event){handleKeys("key-13","#sortbydist","#go","#autosortDist",this)});
		if(divHolder=="#city_Suggest_Main")
			$("#city_Suggest_Main").addClass("city_Suggest_MainWdth");
		$("#city_Suggest_Main").removeClass("autosuggest_divCityDiv");
		if(divHolder=="#city_Suggest_Sub")
			$("#city_Suggest_Sub").addClass("city_Suggest_MainWdth");
		if(divHolder=="#city_Suggest_Sub_lis")
			$("#city_Suggest_Sub_lis").addClass("city_Suggest_MainWdth");
		$("#city_Suggest_Sub").removeClass("autosuggest_divCityDiv");
		$("#city_Suggest_Sub_lis").removeClass("autosuggest_divCityDiv");
		$(divHolder).show();
}

function addRating(rate)
{
	if(rate=='0.0') return;

	var tmp = rate.split('.');
	var star= '<span class="stars_m">';
	for(i=0;i<5;i++)
	{
		if(i<tmp[0])
			star += '<span class="ms10"></span>';
		else if(i==tmp[0] && tmp[1])
			star += '<span class="ms'+tmp[1]+'"></span>';
		else
			star += '<span class="ms0"></span>';
	}
	star += '</span>';
	return star;
}

function timout() {
    auto=false;
    JSON(timeoutURL,timeoutparameter,timeoutdivHolder);
    timeauto = null;
}
var auto = true;var timeoutURL= "";var timeoutparameter= "";var timeoutdivHolder= "";var timeauto= "";
