//start jquery.combobox.js @@@@@@@@@@

/*
jquery.combobox
version 0.1.2.7

*/
jQuery.fn.combobox =
	function(styles, options) {
	    var _context = this;
	    // create a combobox class instance instead of jQuery.fn.combobox which is a namespace.
	    this.combobox = new Function();

	    // Style Settings that determine the look of the control
	    var styleSettings =
		{
		    comboboxContainerClass: null,
		    comboboxValueContentContainerClass: null,
		    comboboxValueContentClass: null,
		    comboboxDropDownButtonClass: null,
		    comboboxDropDownClass: null,
		    comboboxDropDownItemClass: null,
		    comboboxDropDownItemHoverClass: null,
		    comboboxDropDownGroupItemHeaderClass: null,
		    comboboxDropDownGroupItemContainerClass: null
		};

	    // Option settings that determine the functionality of the control
	    var optionSettings =
		{
		    animationType: "slide",
		    animationSpeed: "fast", // can be "fast", "slow", or a number in milliseconds
		    width: 120
		};

	    if (styles) {
	        jQuery.extend(styleSettings, styles);
	    }

	    if (options) {
	        jQuery.extend(optionSettings, options);
	    }

	    //#start public events

	    ///<summary>
	    ///	Called whenever the user selects a different item in the list.
	    ///	By default, event is not called if it has not been assigned.
	    ///</summary>
	    this.combobox.onChange = null;

	    //#end public events

	    //#start private functions

	    ///<summary>
	    ///	Returns the Combobox internal instance
	    ///</summary>
	    function getInstance(context) {
	        return context[0].internalCombobox;
	    }

	    // All make*Function(context) functions, create wrappers around the internal Combobox functions
	    // and makes the function element specific.
	    function makeRemoveFunction(context) {
	        return function() {
	            getInstance(context).remove();
	        };
	    }

	    function makeUpdateFunction(context) {
	        return function() {
	            getInstance(context).update();
	        }
	    }

	    function makeUpdateSelectionFunction(context) {
	        return function() {
	            getInstance(context).updateSelection();
	        }
	    }

	    function makeAddRangeFunction(context) {
	        return function(dataSource) {
	            getInstance(context).addRange(dataSource);
	        }
	    }

	    //#end private functions

	    //#start exposed public methods

	    // Add functionality to the combobox namespace
	    jQuery.fn.extend(
			this.combobox,
			{
			    addRange: makeAddRangeFunction(_context),
			    remove: makeRemoveFunction(_context),
			    update: makeUpdateFunction(_context),
			    updateSelection: makeUpdateSelectionFunction(_context)
			});

	    //#end exposed public methods

	    return this.each(
			function() {
			    // Create a new instance of the Combobox Class, intialising it with the DOM element to operate on and
			    // attach the instance to the DOM
			    this.internalCombobox = new ComboboxClass(this);

			    // Call the instance to initialise itself
			    this.internalCombobox.initialise();

			    ///<summary>
			    ///		a state-based class that is performs all functions necessary for the Combobox to work
			    ///</summary>
			    function ComboboxClass(elementDOM) {
			        //#start 'private' variables

			        // This class can operate on N amount of elements depending how combobox() is called
			        // for example $("select").combobox() could return multiple Selects.
			        // This variable should always be a Select JQuery element.
			        // TODO: Check if select control is used
			        var _originalElementJQuery = jQuery(elementDOM);
			        var _containerJQuery = null;
			        var _containerDefaultStyle = "background-color:#fff;border-left: solid 2px #777;border-top: solid 2px #777;border-right: solid 1px #ccc;border-bottom: solid 1px #ccc;";
			        var _containerEnforcedStyle = "padding:0;";
			        var _dropDownListJQuery = null;
			        var _dropDownListEnforcedStyle = "list-style-type:none;min-height:15px;padding-top:0;margin:0;overflow:auto";
			        var _dropDownListDefaultStyle = "cursor:default;padding:2px;background:#fff;border-right:solid 1px #000;border-bottom:solid 1px #000;border-left:solid 1px #aaa;border-top:solid 1px #aaa;";
			        var _dropDownListItemEnforcedStyle = "display:block;";
			        var _dropDownListItemDefaultStyle = "cursor:default;padding-left:2px;font-weight:normal;font-style:normal;";
			        var _dropDownListGroupItemContainerEnforcedStyle = "list-style-type:none;";
			        var _dropDownListGroupItemContainerDefaultStyle = "padding-left:10px;margin-left:0;";
			        var _dropDownListGroupItemHeaderEnforcedStyle = "";
			        var _dropDownListGroupItemHeaderDefaultStyle = "font-style:italic;font-weight:bold;";
			        var _dropdownListMaximumHeight = 300; // default max height: 300px
			        var _valueContentContainerJQuery = null;
			        var _valueContentContainerEnforcedStyle = "position:relative;overflow:hidden;";
			        var _valueContentJQuery = null;
			        var _valueContentEnforcedStyle = "float:left;position:absolute;cursor:default;overflow:hidden;";
			        var _valueContentDefaultStyle = "padding-left:3px;";
			        var _dropDownButtonJQuery = null;
			        var _dropDownButtonDefaultStyle = "overflow:hidden;width:16px;height:18px;color:#000;background:#D6D3CE;font-family:arial;font-size:8px;cursor:default;text-align:center;vertical-align:middle;";
			        var _dropDownButtonEnforcedStyle = "background-repeat:no-repeat;float:right;";
			        var _dropDownButtonDefaultUnselectedStyle = "padding-left:0px;padding-top:1px;width:12px;height:13px;border-right:solid 2px #404040;border-bottom:solid 2px #404040;border-left:solid 2px #f0f0f0;border-top:solid 2px #f0f0f0";
			        var _dropDownButtonDefaultSelectedStyle = "padding-left:1px;padding-top:3px;width:12px;height:13px;border:solid 1px #808080";
			        var _dropDownButtonDefaultCharacter = "&#9660;"; //down-arrow character
			        var _lastItemSelectedJQuery = null;
			        var _lastItemHoveredJQuery = null;
			        var _lastValue = null;
			        var _downdownListPositionIsInverted = false;
			        var _maximumItemLength = 0;
			        var _dropDownListOffset = null;
			        var _dropDownListHeight = 0;
			        var _dropDownButtonImageDimension = null;
			        var _valueContentContainerImageDimension = null;
			        var _valueContentMaximumHeight = null;

			        //#end 'private' variables

			        //#start 'private' methods

			        ///<summary>
			        /// Function extension to String.
			        ///	Replaces the placeholder tags '{0}...{n}' with the parameters based on ordinal position of the parameters
			        ///	Example: String.format("The quick {0} fox {2} over the lazy {1}.", "brown", "Dog", "jumps");
			        ///	Output:	The quick brown fox jumps over the lazy Dog.
			        ///</summary>
			        String.format =
						function() {
						    var currentString = null;
						    if (arguments.length != 0) {
						        currentString = arguments[0];
						        for (var argumentIndex = 1; argumentIndex < arguments.length; argumentIndex++) {
						            var modifiedString = new RegExp('\\{' + (argumentIndex - 1) + '\\}', 'gm');
						            currentString = currentString.replace(modifiedString, arguments[argumentIndex]);
						        }
						    }

						    return currentString;
						};

			        ///<summary>
			        ///	Returns the value from a string that has 'px' embedded.
			        ///	This function is normally used when working with CSS values.
			        ///	Note: returns null if the extension is not 'px', i.e. it may be 'em', 'pt', etc.
			        ///</summary>
			        function getPixelValue(object) {
			            var pixelValue = null;

			            if (object) {
			                if (object.substr(-2, 2) == "px") {
			                    pixelValue = object.substr(0, (object.length - 2));
			                }
			            }

			            return pixelValue;
			        }

			        ///<summary>
			        ///	Sets the width of an element taking into consideration any borders and padding.
			        ///	Works exactly like Internet Explorers Box Model, where the padding and border is considered
			        //	part of the width. For the purposes of this control, it is required in certain circumstances.
			        ///	Example:
			        ///	 <div id="container" style="width: 150px; border:solid 2px #000"></div>
			        ///		jQuery('#container').width(); // 150px
			        ///		jQuery('#container').outerWidth(); // 154px (2px border on the left and right)
			        ///		setInnerWidth(jQuery('#container'), 120);
			        ///		jQuery('#container').width(); // 116px
			        ///		jQuery('#container').outerWidth(); // 120px (2px border on the left and right)
			        ///</summary>				
			        function setInnerWidth(elementJQuery, width) {
			            var differenceWidth = (elementJQuery.outerWidth() - elementJQuery.width());

			            elementJQuery.width(width - differenceWidth);
			        }

			        ///<summary>
			        ///	Sets the height of an element taking into consideration any borders and padding.
			        ///	Works exactly like Internet Explorers Box Model, where the padding and border is considered
			        //	part of the height. For the purposes of this control, it is required in certain circumstances.			
			        ///</summary>				
			        function setInnerHeight(elementJQuery, height) {
			            var differenceheight = (elementJQuery.outerHeight() - elementJQuery.height());

			            elementJQuery.height(height - differenceheight);
			        }

			        ///<summary>
			        /// Applies CSS styling from a string that contains multiple style styleSettings
			        ///	Example: "background-color:#fff;color:#0f0;border:solid 1px #00f;"
			        ///</summary>			
			        function applyMultipleStyles(elementJQuery, multipleCSSStyles) {
			            var stylePairArray = multipleCSSStyles.split(";");
			            if (stylePairArray.length > 0) {
			                for (var stylePairArrayIndex = 0; stylePairArrayIndex < stylePairArray.length; stylePairArrayIndex++) {
			                    var stylePair = stylePairArray[stylePairArrayIndex];
			                    var splitStylePair = stylePair.split(":");

			                    elementJQuery.css(splitStylePair[0], splitStylePair[1]);
			                }
			            }
			        }

			        ///<summary>
			        ///	Calculates the width and height of an image from its URL
			        ///</summary>
			        function getImageDimension(imageURL) {
			            var dimension = new Object();
			            dimension.width = 0;
			            dimension.height = 0;

			            sizingImageJQuery = jQuery("<img style='border:none;margin:0;padding:0;'></img>");
			            sizingImageJQuery.attr("src", imageURL);

			            _containerJQuery.append(sizingImageJQuery);

			            dimension.width = sizingImageJQuery.width();
			            dimension.height = sizingImageJQuery.height();

			            sizingImageJQuery.remove();

			            return dimension;
			        }

			        ///<summary>
			        ///	Calculates the background image size for an JQuery element if it has a CSS background-image set.
			        ///</summary>
			        function calculateIndividualImageDimension(jqueryElement) {
			            var dimension = null;
			            var backgroundImageURL = jqueryElement.css("background-image");
			            // Depending on the browser, the URL of the background-image sometimes is padded with extra characters
			            backgroundImageURL = backgroundImageURL.replace("url(", "", "gi");
			            backgroundImageURL = backgroundImageURL.replace('"', '', "gi");
			            backgroundImageURL = backgroundImageURL.replace('\"', '', "gi");
			            backgroundImageURL = backgroundImageURL.replace(")", "", "gi");

			            if (backgroundImageURL != "none") {
			                dimension = getImageDimension(backgroundImageURL);
			            }

			            return dimension;
			        }

			        ///<summary>
			        ///	Calculates the background image size for the value display and drop down button.
			        ///	These dimensions are used for control states, normal, pressed [, and hover]
			        ///</summary>
			        function calculateImageDimensions() {
			            _dropDownButtonImageDimension = calculateIndividualImageDimension(_dropDownButtonJQuery);
			            _valueContentContainerImageDimension = calculateIndividualImageDimension(_valueContentContainerJQuery);

			        }

			        ///<summary>
			        ///	Changes the visual of the value container to indicate a state.
			        ///	If the background-image is set and does not contain additional images for states,
			        ///	then the image is not changed for the different states. The Select for Safari works like this.
			        ///	The image states are stored below each other
			        ///	NOTE: This is different from the Drop Down Button where the images are stored side by side.
			        /// for example
			        ///	A value container has a width of 275 pixels and a height of 35 pixels.
			        ///	The background-image is set to valuebackground.gif.
			        ///	valuebackground.gif is 70 pixels in height. The 'pressed' state image is at pixel height 35 in the image.
			        ///	States are:
			        ///	Normal = 0
			        ///	Pressed = 1
			        ///</summary>
			        function setValueContentContainerState(state) {
			            if (styleSettings.comboboxValueContentContainerClass) {
			                // Only process buttomn states if a background-image has been set
			                if (_valueContentContainerImageDimension != null) {
			                    var height = _valueContentContainerJQuery.height();
			                    var offset = (state * height);

			                    // Check if the image is higher than the set height.
			                    // This signifies that the image file contain different images below each other for different
			                    // states.
			                    if (_valueContentContainerImageDimension.height > offset) {
			                        var background_positionCSS = String.format("0px -{0}px", offset);
			                        _valueContentContainerJQuery.css("background-position", background_positionCSS);
			                    }
			                }
			            }
			        }

			        ///<summary>
			        ///	Changes the visual of the drop down button to indicate a state.
			        ///	If the background-image is not set, then the default style is applied.
			        ///	If the background-image is set and does not contain additional images for states,
			        ///	then the image is not changed for the different states. The Select for Safari works like this.
			        ///	The image states are stored side by side: for example
			        ///	A drop-down button has a width of 16 pixel. The background-image is set to button.gif
			        ///	Button.gif is 32 pixels wide. The 'pressed' state image is at pixel position 16 in the image.
			        ///	States are:
			        ///	Normal = 0
			        ///	Pressed = 1
			        ///</summary>
			        function setDropDownButtonState(state) {
			            if (styleSettings.comboboxDropDownButtonClass) {
			                // Only process buttomn states if a background-image has been set
			                if (_dropDownButtonImageDimension != null) {
			                    var width = _dropDownButtonJQuery.width();
			                    var offset = (state * width);

			                    // Check if the image is wider than the set width.
			                    // This signifies that the image file contain different images next to each other for different
			                    // states.
			                    if (_dropDownButtonImageDimension.width > offset) {
			                        var background_positionCSS = String.format("-{0}px 0px", offset);
			                        _dropDownButtonJQuery.css("background-position", background_positionCSS);
			                    }
			                }
			            }
			            else {
			                var style = _dropDownButtonDefaultUnselectedStyle;

			                if (state == 1) {
			                    style = _dropDownButtonDefaultSelectedStyle;
			                }

			                applyMultipleStyles(_dropDownButtonJQuery, style);
			            }
			        }

			        ///<summary>
			        ///	Changes the visual appearance of the controls to represent the current state.
			        ///	States are:
			        ///	Normal = 0
			        ///	Pressed = 1
			        ///</summary>
			        function setControlVisualState(state) {
			            setValueContentContainerState(state);

			            setDropDownButtonState(state);
			        }

			        ///<summary>
			        /// Builds the elements that make up the always visible portion of the control.
			        ///	The equivalent of a Textbox-type element.
			        /// Also creates the DropDownButton
			        ///</summary>
			        function buildValueContent() {

			            // A container for the Display Value and DropDownButton. A container is required as the child elements
			            // are floated
			            var valueContentContainerHTML = "";
			            if (styleSettings.comboboxValueContentContainerClass) {
			                valueContentContainerHTML = String.format("<div class='{0}' style='{1}'></div>", styleSettings.comboboxValueContentContainerClass, _valueContentContainerEnforcedStyle);
			            }
			            else {
			                valueContentContainerHTML = String.format("<div style='{0}'></div>", _valueContentContainerEnforcedStyle);
			            }

			            // Create the equivalent of the select 'textbox' where the current selected value is shown
			            var valueContentHTML = "";
			            if (styleSettings.comboboxValueContentClass) {
			                valueContentHTML = String.format("<div class='{0}' style='{1}'></div>", styleSettings.comboboxValueContentClass, _valueContentEnforcedStyle);
			            }
			            else {
			                valueContentHTML = String.format("<div style='{0}'></div>", _valueContentEnforcedStyle + _valueContentDefaultStyle);
			            }

			            var dropdownButtonHTML = "";
			            if (styleSettings.comboboxDropDownButtonClass) {
			                dropdownButtonHTML = String.format("<div class='{1}' style='{0}'></div>", _dropDownButtonEnforcedStyle, styleSettings.comboboxDropDownButtonClass);
			            }
			            else {
			                dropdownButtonHTML = String.format("<div style='{0}'>{1}</div>", (_dropDownButtonEnforcedStyle + _dropDownButtonDefaultStyle), _dropDownButtonDefaultCharacter);
			            }

			            _valueContentJQuery = jQuery(valueContentHTML);
			            _dropDownButtonJQuery = jQuery(dropdownButtonHTML);
			            _valueContentContainerJQuery = jQuery(valueContentContainerHTML);

			            _valueContentContainerJQuery.appendTo(_containerJQuery);
			            _valueContentJQuery.appendTo(_valueContentContainerJQuery);
			            _dropDownButtonJQuery.appendTo(_valueContentContainerJQuery);

			            calculateImageDimensions();

			            _valueContentMaximumHeight = getPixelValue(_valueContentJQuery.css("max-height"));

			            // Set control to normal state
			            setControlVisualState(0);
			        }

			        ///<summary>
			        ///	Build a drop down list element populating it will values, text, styles and class
			        ///	depending on the source value type. The source value (childJQuery) can be an option or
			        ///	and optgroup element.
			        ///</summary>
			        function buildDropDownItem(childJQuery) {
			            var dataItemHTML = "";
			            var dataItemClass = null;
			            var dataItemText = "";
			            var dataItemTitle = "";
			            var dataItemValue = null;
			            var dataItemStyle = "";
			            var dataItemType = "option";
			            var childElement = childJQuery[0];

			            if (childElement.title) {
			                if (childElement.title != "") {
			                    dataItemTitle = childElement.title;
			                }
			            }

			            if (childJQuery.is('option')) {
			                if (childElement.dataText) {
			                    dataItemText = childElement.dataText;
			                }
			                else {
			                    dataItemText = childJQuery.text();
			                }
			                dataItemValue = childJQuery.val();

			                if (styleSettings.comboboxDropDownItemClass) {
			                    dataItemClass = styleSettings.comboboxDropDownItemClass;
			                    dataItemStyle = _dropDownListItemEnforcedStyle;
			                }
			                else {
			                    dataItemStyle = (_dropDownListItemEnforcedStyle + _dropDownListItemDefaultStyle);
			                }

			                if (dataItemClass) {
			                    dataItemHTML = String.format("<li style='{0}' class='{1}'>{2}</li>", dataItemStyle, dataItemClass, dataItemText);
			                }
			                else {
			                    dataItemHTML = String.format("<li style='{0}'>{1}</li>", dataItemStyle, dataItemText);
			                }

			            }
			            else {
			                if (childJQuery[0].dataText) {
			                    dataItemText = childJQuery[0].dataText;
			                }
			                else {
			                    dataItemText = childJQuery.attr('label');
			                }
			                dataItemValue = childJQuery.attr('class');
			                dataItemType = "optgroup";

			                if (styleSettings.comboboxDropDownGroupItemHeaderClass) {
			                    dataItemClass = styleSettings.comboboxDropDownGroupItemHeaderClass;
			                    dataItemStyle = _dropDownListGroupItemHeaderEnforcedStyle;
			                }
			                else {
			                    dataItemStyle = (_dropDownListGroupItemHeaderEnforcedStyle + _dropDownListGroupItemHeaderDefaultStyle);
			                }

			                if (dataItemClass) {
			                    dataItemHTML = String.format("<li><span style='{0}' class='{1}'>{2}</span></li>", dataItemStyle, dataItemClass, dataItemText);
			                }
			                else {
			                    dataItemHTML = String.format("<li><span style='{0}'>{1}</span></li>", dataItemStyle, dataItemText);
			                }
			            }

			            var dataItemJQuery = jQuery(dataItemHTML);

			            // The element's style is set to inline for the calculation of the true width
			            // The element is then reset to its enforced style (display:block) later
			            dataItemJQuery.css("display", "inline");
			            // Store the value with the DOMElement which is persisted with the Browser
			            dataItemJQuery[0].dataText = dataItemText;
			            dataItemJQuery[0].dataValue = dataItemValue;
			            dataItemJQuery[0].dataType = dataItemType;
			            if (dataItemTitle == "") {
			                dataItemTitle = dataItemText
			            }
			            dataItemJQuery[0].title = dataItemTitle;

			            return dataItemJQuery;
			        }

			        ///<summary>
			        ///	Recusively build the drop down list elements based on the options and optgroups contained
			        ///	with the original Select element
			        ///</summary>
			        function recursivelyBuildList(parentJQuery, childrenOptionsJQuery) {
			            childrenOptionsJQuery.each(
							function() {
							    var childJQuery = jQuery(this);
							    var builtDropDownItemJQuery = buildDropDownItem(childJQuery);
							    parentJQuery.append(builtDropDownItemJQuery);

							    // Calculate the true width of the item taking into consideration the offset from the left-edge
							    // of the drop-down list.
							    // Get the left offset of the DropDown list container and subtract that from the builtDropDownItemJQuery left offset
							    //	to get the distance the builtDropDownItemJQuery is from its container
							    var offsetLeft = builtDropDownItemJQuery.offset().left;

							    offsetLeft -= _dropDownListOffset.left;

							    if (offsetLeft < 0) {
							        offsetLeft = 0;
							    }

							    var width = (offsetLeft + builtDropDownItemJQuery.outerWidth());
							    if (width > _maximumItemLength) {
							        _maximumItemLength = width;
							    }

							    // Set the enforced style of display:block after the width has been calculated.
							    applyMultipleStyles(builtDropDownItemJQuery, _dropDownListItemEnforcedStyle);

							    if (childJQuery.is('optgroup')) {
							        var dataGroupItemHTML = "";
							        if (styleSettings.comboboxDropDownGroupItemContainerClass) {
							            dataGroupItemHTML = String.format("<ul style='{0}' class='{1}'></ul>", _dropDownListGroupItemContainerEnforcedStyle, styleSettings.comboboxDropDownGroupItemContainerClass);
							        }
							        else {
							            dataGroupItemHTML = String.format("<ul style='{0}'></ul>", (_dropDownListGroupItemContainerEnforcedStyle + _dropDownListGroupItemContainerDefaultStyle));
							        }

							        var dataGroupItemJQuery = jQuery(dataGroupItemHTML);
							        builtDropDownItemJQuery.append(dataGroupItemJQuery);

							        // If not an option, then the child of a Select must be an optgroup element
							        recursivelyBuildList(dataGroupItemJQuery, childJQuery.children());
							    }
							});
			        }

			        ///<summary>
			        /// Creates an unordered list of values from the original Select control
			        ///</summary>
			        function buildDropDownList() {
			            var originalElementChildrenJQuery = _originalElementJQuery.children();
			            _lastItemSelectedJQuery = null;
			            _lastValue = null;

			            // If the Drop Down List container already exists, recreate only the items,
			            // else create the container and the items as well.
			            if (_dropDownListJQuery) {
			                // Clear out any existing children elements
			                _dropDownListJQuery.empty();
			            }
			            else {
			                var dropDownHTML = "";
			                if (styleSettings.comboboxDropDownClass) {
			                    dropDownHTML = String.format("<ul class='{0}' style='{1}'></ul>", styleSettings.comboboxDropDownClass, _dropDownListEnforcedStyle);
			                }
			                else {
			                    dropDownHTML = String.format("<ul style='{0}'></ul>", (_dropDownListEnforcedStyle + _dropDownListDefaultStyle));
			                }

			                _dropDownListJQuery = jQuery(dropDownHTML);
			                // Create the equivalent of the drop down list where the all the values are shown
			                _dropDownListJQuery.appendTo(_containerJQuery);

			                // Enable the Drop Down List to be able to receive focus and key events
			                _dropDownListJQuery.attr("tabIndex", 0);
			            }

			            // Create the internal list of values if they exist
			            if (originalElementChildrenJQuery.length > 0) {
			                _maximumItemLength = 0;
			                _dropDownListOffset = _dropDownListJQuery.offset();

			                recursivelyBuildList(_dropDownListJQuery, originalElementChildrenJQuery);
			            }

			            // Check if the max-height has been set as a CSS setting
			            // If it has, determine if the current height of the dropdown list does not exceed it and if 
			            // it does, reset the height to match the setting.
			            var maximumHeight = getPixelValue(_dropDownListJQuery.css("max-height"));

			            // Only use the maximum height if it has been set correctly
			            if (maximumHeight) {
			                _dropdownListMaximumHeight = maximumHeight;
			            }

			            var dropdownListHeight = _dropDownListJQuery.height();
			            if (dropdownListHeight > _dropdownListMaximumHeight) {
			                _dropDownListJQuery.height(_dropdownListMaximumHeight);
			            }

			            // Store the height because the browser flashes (FF) when accessing this function
			            _dropDownListHeight = _dropDownListJQuery.height();
			        }

			        ///<summary>
			        ///	Adjust the width of the DropDown list based on the widest item or the set width (options), whichever
			        ///	is larger.
			        ///</summary>
			        function updateDropDownListWidth() {
			            //Drop down list element
			            var dropdownListWidth = _containerJQuery.outerWidth();
			            if (dropdownListWidth < _maximumItemLength) {
			                dropdownListWidth = _maximumItemLength;
			            }

			            _dropDownListJQuery.width(dropdownListWidth);
			        }

			        ///<summary>
			        /// Repositions the display value based on height of the element.
			        ///	Note: the height will only have meaning if the display value element has text
			        ///</summary>
			        function positionDisplayValue() {
			            // Set the height to the default and allow it to fill the height to accomodate the content
			            _valueContentJQuery.height("auto");
			            var displayValueHeight = _valueContentJQuery.outerHeight();
			            var displayContainerHeight = _valueContentContainerJQuery.height();

			            // Check if the developer wants to clip the content within a region
			            if (_valueContentMaximumHeight) {
			                // Set the height of the content to the maximumContentHeight if it is less
			                // than the current height of the content
			                if (_valueContentMaximumHeight < displayValueHeight) {
			                    displayValueHeight = _valueContentMaximumHeight;
			                    _valueContentJQuery.height(displayValueHeight);
			                }
			            }

			            var difference = ((displayContainerHeight - displayValueHeight) / 2);

			            if (difference < 0) {
			                difference = 0;
			            }

			            //TODO: add other alignments for the user, such as left, top, middle, bottom, etc
			            _valueContentJQuery.css("top", difference);
			        }

			        ///<summary>
			        ///	Applies custom layout position and sizing to the controls
			        ///</summary>
			        function applyLayout() {
			            _containerJQuery.width(optionSettings.width);

			            // Removes any units and retrieves only the value of width
			            var controlWidth = _containerJQuery.width();
			            setInnerWidth(_valueContentContainerJQuery, controlWidth);

			            var displayValueWidth = (_valueContentContainerJQuery.width() - _dropDownButtonJQuery.outerWidth());
			            setInnerWidth(_valueContentJQuery, displayValueWidth);
			            var dropDownButtonHeight = _dropDownButtonJQuery.outerHeight();
			            setInnerHeight(_valueContentContainerJQuery, dropDownButtonHeight);

			            _dropDownListJQuery.css("position", "absolute");
			            _dropDownListJQuery.css("z-index", "20000");

			            updateDropDownListWidth();

			            // Position the drop down list correctly, taking the main display control border into consideration
			            var currentLeftPosition = _dropDownListJQuery.offset().left;
			            var leftPosition = (currentLeftPosition - (_containerJQuery.outerWidth() - _containerJQuery.width()));
			            _dropDownListJQuery.css("left", leftPosition + 1);

			            _dropDownListJQuery.hide();
			        }

			        ///<summary>
			        ///		Sets the value both internally and visually to the user
			        ///</summary>
			        function setContentDisplay() {
			            var valueHasChanged = false;
			            var originalElement = _originalElementJQuery[0];
			            var dataItemJQuery;

			            if (originalElement.length > 0) {
			                //var selectedText = originalElement[originalElement.selectedIndex].text;
			                var selectedDropDownListItemJQuery = jQuery("li[@dataValue='" + _originalElementJQuery.val() + "']", _dropDownListJQuery);

			                _valueContentJQuery.html(selectedDropDownListItemJQuery[0].dataText);
			                _valueContentJQuery.attr("title", selectedDropDownListItemJQuery[0].title);

			                // Reposition the display value based on height of the element after the text has changed
			                positionDisplayValue();

			                if (_lastValue) {
			                    if (_lastValue != _originalElementJQuery.val()) {
			                        valueHasChanged = true;
			                    }
			                }

			                _lastValue = _originalElementJQuery.val();

			                //  If the selected value has changed since the last click, fire the onChange event
			                if (valueHasChanged) {
			                    // Check if the onChange event is being consumed, otherwise it will be undefined
			                    if (_context.combobox.onChange) {
			                        _context.combobox.onChange();
			                    }
			                }

			                // If _lastItemSelectedJQuery has been set, remove the highlight from it, before setting it to the current
			                // value
			                if (_lastItemSelectedJQuery) {
			                    toggleItemHighlight(_lastItemSelectedJQuery, false);
			                }

			                // Find the DropDown Item Element that corresponds to the current value in the Select element
			                _lastItemSelectedJQuery = selectedDropDownListItemJQuery;

			                toggleItemHighlight(_lastItemSelectedJQuery, true);
			            }
			        }

			        ///<summary>
			        ///	Forces the a drop down list item to be visible on screen.
			        ///	This applies to containers that have scrollbars and elements within it
			        ///	are out of vision.
			        ///	Only scrolls an item into place if it not visible on screen.
			        ///</summary>
			        function scrollDropDownListItemIntoView(dropdownListItemJQuery) {
			            //TODO: Not working correctly in IE.
			            // Moving up does not immediately show the hidden item above
			            if (dropdownListItemJQuery) {
			                if (_dropDownListHeight >= _dropdownListMaximumHeight) {
			                    var offset = dropdownListItemJQuery.offset();

			                    // Only scroll if the item is below the height of the ddl
			                    // or above the top of it or the height of a DDL item
			                    if (
										(offset.top > _dropDownListHeight)
										||
										(offset.top <= dropdownListItemJQuery.outerHeight())
									 ) {
			                        dropdownListItemJQuery[0].scrollIntoView();
			                    }
			                }
			            }
			        }

			        ///<summary>
			        ///	Highlights/Unhighlights a specific option.
			        ///	If a class is not set, then the background and foreground colours are inverted
			        ///</summary>
			        function toggleItemHighlight(elementJQuery, isHighlighted) {
			            if (elementJQuery) {
			                if (styleSettings.comboboxDropDownItemHoverClass) {
			                    if (isHighlighted) {
			                        elementJQuery.addClass(styleSettings.comboboxDropDownItemHoverClass);
			                    }
			                    else {
			                        elementJQuery.removeClass(styleSettings.comboboxDropDownItemHoverClass);
			                    }
			                }
			                else {
			                    if (isHighlighted) {
			                        elementJQuery.css("background", "#000");
			                        elementJQuery.css("color", "#fff");
			                    }
			                    else {
			                        elementJQuery.css("background", "");
			                        elementJQuery.css("color", "");
			                    }
			                }
			            }
			        }

			        ///<summary>
			        ///	Builds the Outermost control and swaps out the original Select element.
			        ///	The Select element then becomes an hidden control within.
			        ///</summary>
			        function buildContainer() {
			            var containerHTML = "";
			            if (styleSettings.comboboxContainerClass) {
			                containerHTML = String.format("<div class='{0}' style='{1}'></div>", styleSettings.comboboxContainerClass, _containerEnforcedStyle);
			            }
			            else {
			                containerHTML = String.format("<div style='{0}' style='{1}'></div>", _containerDefaultStyle, _containerEnforcedStyle);
			            }
			            _containerJQuery = jQuery(containerHTML);
			            _originalElementJQuery.before(_containerJQuery);
			            _containerJQuery.append(_originalElementJQuery);
			            _originalElementJQuery.hide();

			            // Allow the custom jquery.combobox be able to receive focus and key events
			            _containerJQuery.attr("tabIndex", 0);
			        }

			        ///<summary>
			        ///	Converts an existing Select element to a JQuery.combobox.
			        ///	The Select element is kept and updated accordingly, but visually is represented
			        ///	by other richer HTML elements
			        ///</summary>
			        this.initialise =
						function() {
						    buildContainer();

						    buildValueContent();

						    buildDropDownList();

						    applyLayout();

						    bindEvents();

						    setContentDisplay();
						};

			        ///<summary>
			        ///	Focus must be set to the DropDown list element only after it has shown.
			        ///	This is due to IE executing the Blur event before the list has immediately shown
			        ///</summary>
			        function postDropDownListShown() {
			            _dropDownListJQuery.focus();
			            scrollDropDownListItemIntoView(_lastItemSelectedJQuery);
			        }

			        ///<summary>
			        ///	Focus set to the Combobox Container
			        ///</summary>
			        function setAndBindContainerFocus() {
			            _containerJQuery.focus();
			            bindContainerClickEvent();
			        }

			        ///<summary>
			        ///	Slides up the DropDownlist when it is to be placed above the CB
			        ///</summary>
			        function slideUp(newTop) {
			            _dropDownListJQuery.animate(
							{
							    height: "toggle",
							    top: newTop
							},
							optionSettings.animationSpeed,
							postDropDownListShown);
			        }

			        ///<summary>
			        ///	Slides closed the DropDownlist when it is placed above the CB.
			        ///	Binds the CB Container click event after the DDL is hidden to avoid a bug in IE
			        ///	where the click event fires re-opening the DDL.
			        ///</summary>
			        function slideDown(newTop) {
			            _dropDownListJQuery.animate(
							{
							    height: "toggle",
							    opacity: "toggle",
							    top: newTop
							},
							optionSettings.animationSpeed,
							setAndBindContainerFocus);
			        }

			        ///<summary>
			        ///	Toggles the slide with a fade and returning execution to the callback function when down
			        ///</summary>
			        function slideToggle(callback) {
			            _dropDownListJQuery.animate(
							{
							    height: "toggle",
							    opacity: "toggle"
							},
							optionSettings.animationSpeed,
							callback);
			        }

			        ///<summary>
			        ///	Get the proposed top position of the drop down list container.
			        ///	Also sets whether the drop down list is inverted. Inverted means that the
			        ///	list is shown above the container as opposed to the normal position of below the combobox 
			        ///	container
			        ///</summary>
			        function getDropDownListTop() {
			            var comboboxTop = _containerJQuery.position().top;
			            var dropdownListHeight = _dropDownListJQuery.outerHeight();
			            var comboboxBottom = (comboboxTop + _containerJQuery.outerHeight());
			            var windowScrollTop = jQuery(window).scrollTop();
			            var windowHeight = jQuery(window).height();
			            var availableSpaceBelow = (windowHeight - (comboboxBottom - windowScrollTop));
			            var dropdownListTop;

			            // Set values to display dropdown list below combobox as default				
			            dropdownListTop = comboboxBottom;
			            _downdownListPositionIsInverted = false;

			            // Check if there is enough space below to display the full height of the drop down list
			            if (availableSpaceBelow < dropdownListHeight) {
			                // There is no available space below the combobox to display the dropdown list
			                // Check if there is available space above. If not, then display below as default
			                if ((comboboxTop - windowScrollTop) > dropdownListHeight) {
			                    // There is space above
			                    dropdownListTop = (comboboxTop - dropdownListHeight);
			                    _downdownListPositionIsInverted = true;
			                }
			            }

			            return dropdownListTop;
			        }

			        ///<summary>
			        ///	Hides/Shows the list of values.
			        ///	The method of display or hiding is specified as optionSettings.animationType.
			        ///	This method also changes the button state
			        ///</summary>					
			        function toggleDropDownList(isShown) {
			            if (isShown) {
			                if (_dropDownListJQuery.is(":hidden")) {
			                    // Remove the click event from the container because when the dropdown list is shown
			                    // and the container is clicked, the dropdownlist blur event is fired which hides the control
			                    // and the container click is fired after which will show the list again (error);
			                    unbindContainerClickEvent();

			                    // Remove the highlight from the last item hovered before the DDL was retracted
			                    toggleItemHighlight(_lastItemHoveredJQuery, false);

			                    // When the DropDown list is shown, highlist the current value in the list
			                    toggleItemHighlight(_lastItemSelectedJQuery, true);

			                    setControlVisualState(1);

			                    var dropdownListTop = getDropDownListTop();
			                    _dropDownListJQuery.css("top", dropdownListTop);
			                    _dropDownListJQuery.css("left", _containerJQuery.offset().left);

			                    switch (optionSettings.animationType) {
			                        case "slide":
			                            if (_downdownListPositionIsInverted) {
			                                var comboboxTop = _containerJQuery.position().top;
			                                var containerHeight = _containerJQuery.outerHeight();

			                                _dropDownListJQuery.css("top", (comboboxTop - containerHeight));

			                                slideUp(dropdownListTop);
			                            }
			                            else {
			                                slideToggle(postDropDownListShown);
			                            }
			                            break;

			                        case "fade":
			                            _dropDownListJQuery.fadeIn(optionSettings.animationSpeed, postDropDownListShown);
			                            break;

			                        default:
			                            // Bug: if show() is used and postDropDownListShown() is immediately after,
			                            // the focus hides the DropDownList. Show(1, xxx) uses a callback which seems to work
			                            _dropDownListJQuery.show(1, postDropDownListShown);
			                    }
			                }
			            }
			            else {
			                if (_dropDownListJQuery.is(":visible")) {
			                    setControlVisualState(0);

			                    switch (optionSettings.animationType) {
			                        case "slide":
			                            if (_downdownListPositionIsInverted) {
			                                comboboxTop = _containerJQuery.position().top;
			                                dropdownListHeight = _dropDownListJQuery.height();

			                                slideDown(comboboxTop - _containerJQuery.outerHeight());
			                            }
			                            else {
			                                slideToggle(setAndBindContainerFocus);
			                            }
			                            break;

			                        case "fade":
			                            _dropDownListJQuery.fadeOut(optionSettings.animationSpeed, setAndBindContainerFocus);
			                            break;

			                        default:
			                            _dropDownListJQuery.hide();
			                            setAndBindContainerFocus();
			                    }
			                }
			            }
			        }

			        ///<summary>
			        ///	Sets the internal select element (original) to match the visually changes made by the user.
			        ///	This ensures that any legacy code working with the original select is kept up to date with changes
			        /// Either selectedIndex or selectedValue can be used, not both at the same time.
			        ///</summary>
			        function setOriginalSelectItem(selectedIndex, selectedValue) {
			            var originalElementDOM = _originalElementJQuery[0];

			            if (selectedValue == null) {
			                originalElementDOM.selectedIndex = selectedIndex;
			            }
			            else {
			                originalElementDOM.value = selectedValue;
			            }

			            // Fire the OnChange event for the original select element
			            if (originalElementDOM.onchange) {
			                originalElementDOM.onchange();
			            }

			            setContentDisplay();
			        }

			        ///<summary>
			        ///	Selects a value from the list of options from the original Select options.
			        ///	Does not use JQuery Selectors ':last' and ':first' because they take optgroup elements into
			        ///	account.
			        ///</summary>					
			        function selectValue(subSelector) {
			            var originalElement = _originalElementJQuery[0];
			            var currentIndex = originalElement.selectedIndex;
			            var newIndex = -1;
			            // {select}.length returns the array size of the options. Does not count optgroup elements
			            var optionCountZeroBased = originalElement.length - 1;

			            switch (subSelector) {
			                case ":next":
			                    newIndex = currentIndex + 1;
			                    if (newIndex > optionCountZeroBased) {
			                        newIndex = optionCountZeroBased;
			                    }
			                    break;

			                case ":previous":
			                    newIndex = currentIndex - 1;
			                    if (newIndex < 0) {
			                        newIndex = 0;
			                    }

			                    break;

			                case ":first":
			                    newIndex = 0;

			                    break;

			                case ":last":
			                    newIndex = optionCountZeroBased;

			                    break;
			            }

			            setOriginalSelectItem(newIndex, null);

			            scrollDropDownListItemIntoView(_lastItemSelectedJQuery);
			        }

			        ///<summary>
			        ///	Returns true if the DropDownList visible on screen, else false
			        ///</summary>
			        function isDropDownVisible() {
			            return _dropDownListJQuery.is(":visible");
			        }

			        ///<summary>
			        /// Bind all items to mouse events except for UL elements
			        /// and LI elements that are option group labels
			        ///</summary>			
			        function bindItemEvents() {
			            jQuery("li", _dropDownListJQuery).not("ul").not("span").not("[@dataType='optgroup']").each(
							function() {
							    var itemJQuery = jQuery(this);
							    itemJQuery.click(
									function(clickEvent) {
									    // Stops the click event propagating to the Container and the Container.onClick firing
									    clickEvent.stopPropagation();

									    dropdownList_onItemClick(itemJQuery);
									});

							    itemJQuery.mouseover(
									function() {
									    dropdownList_onItemMouseOver(itemJQuery);
									});

							    itemJQuery.mouseout(
									function() {
									    dropdownList_onItemMouseOut(itemJQuery);
									});
							});
			        }

			        ///<summary>
			        ///		Bind the dropdown list control blur event to a function
			        ///</summary>
			        function bindBlurEvent() {
			            _dropDownListJQuery.blur(
							function(blurEvent) {
							    blurEvent.stopPropagation();

							    dropdownList_onBlur();
							});
			        }

			        ///<summary>
			        ///	Bind the click event of the container to a function
			        ///</summary>
			        function bindContainerClickEvent() {
			            _containerJQuery.click(
							function() {
							    container_onClick();
							});
			        }

			        ///<summary>
			        ///	Remove the binding of a custom function from the container's click event
			        ///</summary>
			        function unbindContainerClickEvent() {
			            _containerJQuery.unbind("click");
			        }

			        ///<summary>
			        ///		Bind this control to the events to custom functions
			        ///</summary>
			        function bindEvents() {
			            _containerJQuery.keydown(
							function(keyEvent) {
							    keyEvent.preventDefault();
							    container_onKeyDown(keyEvent)
							});

			            bindContainerClickEvent();

			            bindBlurEvent();

			            bindItemEvents();
			        }

			        //#end 'private' functions

			        //#start private events

			        ///<summary>
			        ///	If the drop down list is retracted, it is shown,
			        ///	else if shown, it is retracted
			        ///</summary>
			        function container_onClick() {
			            if (_dropDownListJQuery.is(":hidden")) {
			                toggleDropDownList(true);
			            }
			            else {
			                toggleDropDownList(false);
			            }
			        }

			        ///<summary>
			        ///	Fires when the drop down list loses focus.
			        ///	On Blur, the drop down list is retracted
			        ///</summary>
			        function dropdownList_onBlur() {
			            if (_dropDownListJQuery.is(":visible")) {
			                toggleDropDownList(false);
			            }
			        }

			        ///<summary>
			        ///	Retrieves the value of the item clicked, sets the content to that value
			        ///	and retracts the drop-down list
			        ///</summary>
			        function dropdownList_onItemClick(itemJQuery) {
			            setOriginalSelectItem(null, itemJQuery[0].dataValue);

			            toggleDropDownList(false);
			        }

			        ///<summary>
			        ///	Highlights the Drop Down List item currently under the mouse.
			        ///	Removes the highlist from the previous selected item as well.
			        ///</summary>
			        function dropdownList_onItemMouseOver(itemJQuery) {
			            // An item may be selected from the previous selection and will require
			            // to be set to normal.
			            // TODO: find a better method of matching _lastItemSelectedJQuery to itemJQuery and optimising the removal
			            // of the class, instead of removing it consistently
			            toggleItemHighlight(_lastItemSelectedJQuery, false);

			            toggleItemHighlight(_lastItemHoveredJQuery, false);

			            toggleItemHighlight(itemJQuery, true);
			        }

			        ///<summary>
			        ///		Removes the highlight from the selected item
			        ///</summary>
			        function dropdownList_onItemMouseOut(itemJQuery) {
			            //toggleItemHighlight(itemJQuery, false);
			            _lastItemHoveredJQuery = itemJQuery;
			        }

			        ///<summary>
			        ///	Handles the keyboard navigation aspect of the combobox.
			        ///	Note: Does not jump to item if the first letter is pressed.
			        ///</summary>
			        //TODO: Correctly support page-up and page-down, esp. with scrolling
			        function container_onKeyDown(keyEvent) {
			            switch (keyEvent.which) {
			                case 33:
			                    //Page Up
			                case 36:
			                    //Home
			                    selectValue(":first");
			                    break;

			                case 34:
			                    //Page Down
			                case 35:
			                    //End
			                    selectValue(":last");
			                    break;

			                case 37:
			                    //Left
			                    selectValue(":previous");
			                    break;

			                case 38:
			                    //Up
			                    if (keyEvent.altKey) {
			                        // alt-up
			                        // If DDL is hidden, then it is shown and vice-versa
			                        toggleDropDownList(!(isDropDownVisible()));
			                    }
			                    else {
			                        selectValue(":previous");
			                    }
			                    break;

			                case 39:
			                    //Right
			                    selectValue(":next");
			                    break;

			                case 40:
			                    //Down
			                    if (keyEvent.altKey) {
			                        // alt-down
			                        // If DDL is hidden, then it is shown and vice-versa
			                        toggleDropDownList(!(isDropDownVisible()));
			                    }
			                    else {
			                        selectValue(":next");
			                    }
			                    break;

			                case 27:
			                case 13:
			                    // Escape
			                    toggleDropDownList(false);
			                    break;

			                case 9:
			                    // Tab
			                    //TODO: Support alt-tab
			                    //TODO: Does not truly leave the Combobox if the DropDown is visible
			                    _dropDownListJQuery.blur();

			                    // This is required in Internet Explorer as the blur() order is different
			                    jQuery(window)[0].focus();

			                    break;
			            }
			        }
			        //#end private events

			        //#start public methods

			        ///<summary>
			        ///	Updates the combobox with the current selected item.
			        ///	This function is called if the original Select element selection has been changed
			        ///</summary>
			        this.updateSelection =
						function() {
						    setContentDisplay();
						};

			        ///<summary>
			        ///	The Drop Down List Container will already have been created.
			        ///	This function recreates the items and binds the events to them.
			        ///	Thereafter, the current selection is set.
			        ///</summary>
			        this.update =
						function() {
						    buildDropDownList();
						    updateDropDownListWidth();
						    bindItemEvents();
						    setContentDisplay();
						};

			        ///<summary>
			        ///	Removes the jquery.combobox leaving the original select element
			        ///</summary>					
			        this.remove =
						function() {
						    //Move the original element to a position before the jquery.combobox			
						    _containerJQuery.before(_originalElementJQuery);
						    _containerJQuery.remove();

						    // Remove the internal object property from the DOM
						    //TODO: next statement does not work in Internet Explorer 6.
						    //delete _originalElementJQuery[0].internalCombobox;
						    _originalElementJQuery[0].internalCombobox = null;

						    _originalElementJQuery.show();
						};

			        ///<summary>
			        ///	Adds a range of options into the combobox.
			        ///	Using this function bypasses the browsers restriction of adding
			        ///	html as text values. This allows customisation of the display text
			        ///	Format of dataSource
			        ///	[
			        ///		{
			        ///			value: object, // usual a unique string value
			        ///			text: object,  // can be normal text or html
			        ///			title: string  // optional
			        ///		}
			        ///	]
			        ///	Note: Still in development
			        ///</summary>
			        this.addRange =
						function(dataSource) {
						    if (dataSource) {
						        var originalOptions = _originalElementJQuery[0].options;
						        var optionTotal = originalOptions.length;
						        for (optionIndex in dataSource) {
						            var option = dataSource[optionIndex];
						            var optionElement = document.createElement("option");
						            optionElement.value = option.value;
						            optionElement.text = option.text;
						            // Store the raw text data. Option.text removes all HTML content
						            optionElement.dataText = option.text;
						            if (option.title) {
						                optionElement.title = option.title;
						            }

						            originalOptions[optionTotal + optionIndex] = optionElement;
						        }

						        _originalElementJQuery.combobox.update();
						    }
						};

			        //#end public methods

			    }
			});
	}
/*
TODOS:
- look to moving functions to outside the context and use a state based object to track individual elements [0]
*/


//END jquery.combobox.js @@@@@@@@@@


//Start select location @@@@@@@@@@

$(
			function() {
			    _cssStyleSelectJQ = $("#cssStyleSelect").combobox(
				{ comboboxContainerClass: "comboboxContainer",
				    comboboxValueContentContainerClass: "comboboxValueContainer",
				    comboboxValueContentClass: "comboboxValueContent",
				    comboboxDropDownClass: "comboboxDropDownContainer",
				    comboboxDropDownButtonClass: "comboboxDropDownButton",
				    comboboxDropDownItemClass: "comboboxItem",
				    comboboxDropDownItemHoverClass: "comboboxItemHover",
				    comboboxDropDownGroupItemHeaderClass: "comboboxGroupItemHeader",
				    comboboxDropDownGroupItemContainerClass: "comboboxGroupItemContainer"
				});

			    _cssStyleSelectJQ.combobox.onChange =
					function() {
					    //changeStyle();
					    var cssStyleSelectJQ = $("#cssStyleSelect");
					    var selectedStyle = cssStyleSelectJQ.val();
					    //						alert("dsad"+selectedStyle);
					};
			});

//END select location @@@@@@@@@@



//Start mm.js for menu @@@@@@@@@@

/*********************
//* jQuery Multi Level CSS Menu (horizontal)- By Dynamic Drive DHTML code library: http://www.dynamicdrive.com
//* Menu instructions page: http://www.dynamicdrive.com/dynamicindex1/ddlevelsmenu/
//* Last modified: Sept 6th, 08'. Usage Terms: http://www.dynamicdrive.com/style/csslibrary/tos/
*********************/

//Specify full URL to down and right arrow images (25 is padding-right to add to top level LIs with drop downs):
var arrowimages = { down: ['downarrowclass', 'images/spc.gif', ], right: ['rightarrowclass', 'images/spc.gif'] }

var jquerycssmenu = {

    fadesettings: { overduration: 350, outduration: 100 }, //duration of fade in/ out animation, in milliseconds

    buildmenu: function(menuid, arrowsvar) {
        jQuery(document).ready(function($) {
            var $mainmenu = $("#" + menuid + ">ul")
            var $headers = $mainmenu.find("ul").parent()
            $headers.each(function(i) {
                var $curobj = $(this)
                var $subul = $(this).find('ul:eq(0)')
                this._dimensions = { w: this.offsetWidth, h: this.offsetHeight, subulw: $subul.outerWidth(), subulh: $subul.outerHeight() }
                this.istopheader = $curobj.parents("ul").length == 1 ? true : false
                $subul.css({ top: this.istopheader ? this._dimensions.h + "px" : 0 })
                $curobj.children("a:eq(0)").css(this.istopheader ? { paddingRight: arrowsvar.down[2]} : {}).append(
				'<img src="' + (this.istopheader ? arrowsvar.down[1] : arrowsvar.right[1])
				+ '" class="' + (this.istopheader ? arrowsvar.down[0] : arrowsvar.right[0])
				+ '" style="border:0;" />'
			)
                $curobj.hover(
				function(e) {
				    var $targetul = $(this).children("ul:eq(0)")
				    this._offsets = { left: $(this).offset().left, top: $(this).offset().top }
				    var menuleft = this.istopheader ? 0 : this._dimensions.w
				    menuleft = (this._offsets.left + menuleft + this._dimensions.subulw > $(window).width()) ? (this.istopheader ? -this._dimensions.subulw + this._dimensions.w : -this._dimensions.w) : menuleft
				    $targetul.css({ left: menuleft + "px" }).fadeIn(jquerycssmenu.fadesettings.overduration)
				},
				function(e) {
				    $(this).children("ul:eq(0)").fadeOut(jquerycssmenu.fadesettings.outduration)
				}
			) //end hover
            }) //end $headers.each()
            $mainmenu.find("ul").css({ display: 'none', visibility: 'visible' })
        }) //end document.ready
    }
}

//build menu with ID="myjquerymenu" on page:
jquerycssmenu.buildmenu("myjquerymenu", arrowimages)

//END mm.js for menu @@@@@@@@@@


//START jquery.fancybox-1.2.1.pack.js for menu @@@@@@@@@@

/*
* FancyBox - simple and fancy jQuery plugin
* Examples and documentation at: http://fancy.klade.lv/
* Version: 1.2.1 (13/03/2009)
* Copyright (c) 2009 Janis Skarnelis
* Licensed under the MIT License: http://en.wikipedia.org/wiki/MIT_License
* Requires: jQuery v1.3+
*/
eval(function(p, a, c, k, e, d) { e = function(c) { return (c < a ? '' : e(parseInt(c / a))) + ((c = c % a) > 35 ? String.fromCharCode(c + 29) : c.toString(36)) }; if (!''.replace(/^/, String)) { while (c--) { d[e(c)] = k[c] || e(c) } k = [function(e) { return d[e] } ]; e = function() { return '\\w+' }; c = 1 }; while (c--) { if (k[c]) { p = p.replace(new RegExp('\\b' + e(c) + '\\b', 'g'), k[c]) } } return p } (';(7($){$.b.2Q=7(){u B.2t(7(){9 1J=$(B).n(\'2Z\');5(1J.1c(/^3w\\(["\']?(.*\\.2p)["\']?\\)$/i)){1J=3t.$1;$(B).n({\'2Z\':\'45\',\'2o\':"3W:3R.4m.4d(3h=F, 3T="+($(B).n(\'41\')==\'2J-3Z\'?\'4c\':\'3N\')+", Q=\'"+1J+"\')"}).2t(7(){9 1b=$(B).n(\'1b\');5(1b!=\'2e\'&&1b!=\'2n\')$(B).n(\'1b\',\'2n\')})}})};9 A,4,16=D,s=1t 1o,1w,1v=1,1y=/\\.(3A|3Y|2p|3c|3d)(.*)?$/i;9 P=($.2q.3K&&2f($.2q.3z.2k(0,1))<8);$.b.c=7(Y){Y=$.3x({},$.b.c.2R,Y);9 2s=B;7 2h(){A=B;4=Y;2r();u D};7 2r(){5(16)u;5($.1O(4.2c)){4.2c()}4.j=[];4.h=0;5(Y.j.N>0){4.j=Y.j}t{9 O={};5(!A.1H||A.1H==\'\'){9 O={d:A.d,X:A.X};5($(A).1G("1m:1D").N){O.1a=$(A).1G("1m:1D")}4.j.2j(O)}t{9 Z=$(2s).2o("a[1H="+A.1H+"]");9 O={};3C(9 i=0;i<Z.N;i++){O={d:Z[i].d,X:Z[i].X};5($(Z[i]).1G("1m:1D").N){O.1a=$(Z[i]).1G("1m:1D")}4.j.2j(O)}3F(4.j[4.h].d!=A.d){4.h++}}}5(4.23){5(P){$(\'1U, 1Q, 1P\').n(\'1S\',\'3s\')}$("#1i").n(\'25\',4.2U).J()}1d()};7 1d(){$("#1f, #1e, #V, #G").S();9 d=4.j[4.h].d;5(d.1c(/#/)){9 U=11.3r.d.3f(\'#\')[0];U=d.3g(U,\'\');U=U.2k(U.2l(\'#\'));1k(\'<6 l="3e">\'+$(U).o()+\'</6>\',4.1I,4.1x)}t 5(d.1c(1y)){s=1t 1o;s.Q=d;5(s.3a){1K()}t{$.b.c.34();$(s).x().14(\'3b\',7(){$(".I").S();1K()})}}t 5(d.1c("17")||A.3j.2l("17")>=0){1k(\'<17 l="35" 3q="$.b.c.38()" 3o="3n\'+C.T(C.3l()*3m)+\'" 2K="0" 3E="0" Q="\'+d+\'"></17>\',4.1I,4.1x)}t{$.4p(d,7(2m){1k(\'<6 l="3L">\'+2m+\'</6>\',4.1I,4.1x)})}};7 1K(){5(4.30){9 w=$.b.c.1n();9 r=C.1M(C.1M(w[0]-36,s.g)/s.g,C.1M(w[1]-4b,s.f)/s.f);9 g=C.T(r*s.g);9 f=C.T(r*s.f)}t{9 g=s.g;9 f=s.f}1k(\'<1m 48="" l="49" Q="\'+s.Q+\'" />\',g,f)};7 2F(){5((4.j.N-1)>4.h){9 d=4.j[4.h+1].d;5(d.1c(1y)){1A=1t 1o();1A.Q=d}}5(4.h>0){9 d=4.j[4.h-1].d;5(d.1c(1y)){1A=1t 1o();1A.Q=d}}};7 1k(1j,g,f){16=F;9 L=4.2Y;5(P){$("#q")[0].1E.2u("f");$("#q")[0].1E.2u("g")}5(L>0){g+=L*2;f+=L*2;$("#q").n({\'v\':L+\'z\',\'2E\':L+\'z\',\'2i\':L+\'z\',\'y\':L+\'z\',\'g\':\'2B\',\'f\':\'2B\'});5(P){$("#q")[0].1E.2C(\'f\',\'(B.2D.4j - 20)\');$("#q")[0].1E.2C(\'g\',\'(B.2D.3S - 20)\')}}t{$("#q").n({\'v\':0,\'2E\':0,\'2i\':0,\'y\':0,\'g\':\'2z%\',\'f\':\'2z%\'})}5($("#k").1u(":19")&&g==$("#k").g()&&f==$("#k").f()){$("#q").1Z("2N",7(){$("#q").1C().1F($(1j)).21("1s",7(){1g()})});u}9 w=$.b.c.1n();9 2v=(g+36)>w[0]?w[2]:(w[2]+C.T((w[0]-g-36)/2));9 2w=(f+1z)>w[1]?w[3]:(w[3]+C.T((w[1]-f-1z)/2));9 K={\'y\':2v,\'v\':2w,\'g\':g+\'z\',\'f\':f+\'z\'};5($("#k").1u(":19")){$("#q").1Z("1s",7(){$("#q").1C();$("#k").24(K,4.2X,4.2T,7(){$("#q").1F($(1j)).21("1s",7(){1g()})})})}t{5(4.1W>0&&4.j[4.h].1a!==1L){$("#q").1C().1F($(1j));9 M=4.j[4.h].1a;9 15=$.b.c.1R(M);$("#k").n({\'y\':(15.y-18)+\'z\',\'v\':(15.v-18)+\'z\',\'g\':$(M).g(),\'f\':$(M).f()});5(4.1X){K.25=\'J\'}$("#k").24(K,4.1W,4.2W,7(){1g()})}t{$("#q").S().1C().1F($(1j)).J();$("#k").n(K).21("1s",7(){1g()})}}};7 2y(){5(4.h!=0){$("#1e, #2O").x().14("R",7(e){e.2x();4.h--;1d();u D});$("#1e").J()}5(4.h!=(4.j.N-1)){$("#1f, #2M").x().14("R",7(e){e.2x();4.h++;1d();u D});$("#1f").J()}};7 1g(){2y();2F();$(W).1B(7(e){5(e.29==27){$.b.c.1l();$(W).x("1B")}t 5(e.29==37&&4.h!=0){4.h--;1d();$(W).x("1B")}t 5(e.29==39&&4.h!=(4.j.N-1)){4.h++;1d();$(W).x("1B")}});5(4.1r){$(11).14("1N 1T",$.b.c.2g)}t{$("6#k").n("1b","2e")}5(4.2b){$("#22").R($.b.c.1l)}$("#1i, #V").14("R",$.b.c.1l);$("#V").J();5(4.j[4.h].X!==1L&&4.j[4.h].X.N>0){$(\'#G 6\').o(4.j[4.h].X);$(\'#G\').J()}5(4.23&&P){$(\'1U, 1Q, 1P\',$(\'#q\')).n(\'1S\',\'19\')}5($.1O(4.2a)){4.2a()}16=D};u B.x(\'R\').R(2h)};$.b.c.2g=7(){9 m=$.b.c.1n();$("#k").n(\'y\',(($("#k").g()+36)>m[0]?m[2]:m[2]+C.T((m[0]-$("#k").g()-36)/2)));$("#k").n(\'v\',(($("#k").f()+1z)>m[1]?m[3]:m[3]+C.T((m[1]-$("#k").f()-1z)/2)))};$.b.c.1h=7(H,2A){u 2f($.3I(H.3u?H[0]:H,2A,F))||0};$.b.c.1R=7(H){9 m=H.4g();m.v+=$.b.c.1h(H,\'3k\');m.v+=$.b.c.1h(H,\'3J\');m.y+=$.b.c.1h(H,\'3H\');m.y+=$.b.c.1h(H,\'3D\');u m};$.b.c.38=7(){$(".I").S();$("#35").J()};$.b.c.1n=7(){u[$(11).g(),$(11).f(),$(W).3i(),$(W).3p()]};$.b.c.2G=7(){5(!$("#I").1u(\':19\')){33(1w);u}$("#I > 6").n(\'v\',(1v*-40)+\'z\');1v=(1v+1)%12};$.b.c.34=7(){33(1w);9 m=$.b.c.1n();$("#I").n({\'y\':((m[0]-40)/2+m[2]),\'v\':((m[1]-40)/2+m[3])}).J();$("#I").14(\'R\',$.b.c.1l);1w=3Q($.b.c.2G,3X)};$.b.c.1l=7(){16=F;$(s).x();$("#1i, #V").x();5(4.2b){$("#22").x()}$("#V, .I, #1e, #1f, #G").S();5(4.1r){$(11).x("1N 1T")}1q=7(){$("#1i, #k").S();5(4.1r){$(11).x("1N 1T")}5(P){$(\'1U, 1Q, 1P\').n(\'1S\',\'19\')}5($.1O(4.1V)){4.1V()}16=D};5($("#k").1u(":19")!==D){5(4.26>0&&4.j[4.h].1a!==1L){9 M=4.j[4.h].1a;9 15=$.b.c.1R(M);9 K={\'y\':(15.y-18)+\'z\',\'v\':(15.v-18)+\'z\',\'g\':$(M).g(),\'f\':$(M).f()};5(4.1X){K.25=\'S\'}$("#k").31(D,F).24(K,4.26,4.2S,1q)}t{$("#k").31(D,F).1Z("2N",1q)}}t{1q()}u D};$.b.c.2V=7(){9 o=\'\';o+=\'<6 l="1i"></6>\';o+=\'<6 l="22">\';o+=\'<6 p="I" l="I"><6></6></6>\';o+=\'<6 l="k">\';o+=\'<6 l="2I">\';o+=\'<6 l="V"></6>\';o+=\'<6 l="E"><6 p="E 44"></6><6 p="E 43"></6><6 p="E 42"></6><6 p="E 3V"></6><6 p="E 3U"></6><6 p="E 3O"></6><6 p="E 3M"></6><6 p="E 3P"></6></6>\';o+=\'<a d="2P:;" l="1e"><1p p="1Y" l="2O"></1p></a><a d="2P:;" l="1f"><1p p="1Y" l="2M"></1p></a>\';o+=\'<6 l="q"></6>\';o+=\'<6 l="G"></6>\';o+=\'</6>\';o+=\'</6>\';o+=\'</6>\';$(o).2H("46");$(\'<32 4i="0" 4h="0" 4k="0"><2L><13 p="G" l="4l"></13><13 p="G" l="4o"><6></6></13><13 p="G" l="4n"></13></2L></32>\').2H(\'#G\');5(P){$("#2I").47(\'<17 p="4a" 4e="2J" 2K="0"></17>\');$("#V, .E, .G, .1Y").2Q()}};$.b.c.2R={2Y:10,30:F,1X:D,1W:0,26:0,2X:3G,2W:\'28\',2S:\'28\',2T:\'28\',1I:3B,1x:3v,23:F,2U:0.3,2b:F,1r:F,j:[],2c:2d,2a:2d,1V:2d};$(W).3y(7(){$.b.c.2V()})})(4f);', 62, 274, '||||opts|if|div|function||var||fn|fancybox|href||height|width|itemCurrent||itemArray|fancy_outer|id|pos|css|html|class|fancy_content||imagePreloader|else|return|top||unbind|left|px|elem|this|Math|false|fancy_bg|true|fancy_title|el|fancy_loading|show|itemOpts|pad|orig_item|length|item|isIE|src|click|hide|round|target|fancy_close|document|title|settings|subGroup||window||td|bind|orig_pos|busy|iframe||visible|orig|position|match|_change_item|fancy_left|fancy_right|_finish|getNumeric|fancy_overlay|value|_set_content|close|img|getViewport|Image|span|__cleanup|centerOnScroll|normal|new|is|loadingFrame|loadingTimer|frameHeight|imageRegExp|50|objNext|keydown|empty|first|style|append|children|rel|frameWidth|image|_proceed_image|undefined|min|resize|isFunction|select|object|getPosition|visibility|scroll|embed|callbackOnClose|zoomSpeedIn|zoomOpacity|fancy_ico|fadeOut||fadeIn|fancy_wrap|overlayShow|animate|opacity|zoomSpeedOut||swing|keyCode|callbackOnShow|hideOnContentClick|callbackOnStart|null|absolute|parseInt|scrollBox|_initialize|bottom|push|substr|indexOf|data|relative|filter|png|browser|_start|matchedGroup|each|removeExpression|itemLeft|itemTop|stopPropagation|_set_navigation|100|prop|auto|setExpression|parentNode|right|_preload_neighbor_images|animateLoading|appendTo|fancy_inner|no|frameborder|tr|fancy_right_ico|fast|fancy_left_ico|javascript|fixPNG|defaults|easingOut|easingChange|overlayOpacity|build|easingIn|zoomSpeedChange|padding|backgroundImage|imageScale|stop|table|clearInterval|showLoading|fancy_frame|||showIframe||complete|load|bmp|jpeg|fancy_div|split|replace|enabled|scrollLeft|className|paddingTop|random|1000|fancy_iframe|name|scrollTop|onload|location|hidden|RegExp|jquery|500|url|extend|ready|version|jpg|600|for|borderLeftWidth|hspace|while|300|paddingLeft|curCSS|borderTopWidth|msie|fancy_ajax|fancy_bg_w|scale|fancy_bg_sw|fancy_bg_nw|setInterval|DXImageTransform|clientWidth|sizingMethod|fancy_bg_s|fancy_bg_se|progid|66|gif|repeat||backgroundRepeat|fancy_bg_e|fancy_bg_ne|fancy_bg_n|none|body|prepend|alt|fancy_img|fancy_bigIframe|60|crop|AlphaImageLoader|scrolling|jQuery|offset|cellpadding|cellspacing|clientHeight|border|fancy_title_left|Microsoft|fancy_title_right|fancy_title_main|get'.split('|'), 0, {}))

//END jquery.fancybox-1.2.1.pack.js for menu @@@@@@@@@@


//START jquery.ui-personalized-1.5.2.packed.js for menu @@@@@@@@@@
eval(function(p, a, c, k, e, d) { e = function(c) { return (c < a ? '' : e(parseInt(c / a))) + ((c = c % a) > 35 ? String.fromCharCode(c + 29) : c.toString(36)) }; if (!''.replace(/^/, String)) { while (c--) { d[e(c)] = k[c] || e(c) } k = [function(e) { return d[e] } ]; e = function() { return '\\w+' }; c = 1 }; while (c--) { if (k[c]) { p = p.replace(new RegExp('\\b' + e(c) + '\\b', 'g'), k[c]) } } return p } ('(3(C){C.8={3o:{19:3(E,F,H){6 G=C.8[E].1h;21(6 D 3p H){G.1I[D]=G.1I[D]||[];G.1I[D].28([F,H[D]])}},2P:3(D,F,E){6 H=D.1I[F];5(!H){7}21(6 G=0;G<H.k;G++){5(D.b[H[G][0]]){H[G][1].1H(D.c,E)}}}},1l:{},n:3(D){5(C.8.1l[D]){7 C.8.1l[D]}6 E=C(\'<2a 3s="8-3r">\').j(D).n({3q:"3i",2g:"-2A",3g:"-2A",1r:"1w"}).22("2C");C.8.1l[D]=!!((!(/3I|3P/).12(E.n("3z"))||(/^[1-9]/).12(E.n("2T"))||(/^[1-9]/).12(E.n("2E"))||!(/2v/).12(E.n("3w"))||!(/3S|3C\\(0, 0, 0, 0\\)/).12(E.n("3D"))));3E{C("2C").2w(0).3B(E.2w(0))}3x(F){}7 C.8.1l[D]},3y:3(D){C(D).v("1p","2I").n("2q","2v")},3H:3(D){C(D).v("1p","3O").n("2q","")},3Q:3(G,E){6 D=/2g/.12(E||"2g")?"3N":"3M",F=e;5(G[D]>0){7 t}G[D]=1;F=G[D]>0?t:e;G[D]=0;7 F}};6 B=C.2e.W;C.2e.W=3(){C("*",2).19(2).z("W");7 B.1H(2,2M)};3 A(E,F,G){6 D=C[E][F].35||[];D=(1F D=="1E"?D.2h(/,?\\s+/):D);7(C.1j(G,D)!=-1)}C.1i=3(E,D){6 F=E.2h(".")[0];E=E.2h(".")[1];C.2e[E]=3(J){6 H=(1F J=="1E"),I=2D.1h.3J.2P(2M,1);5(H&&A(F,E,J)){6 G=C.i(2[0],E);7(G?G[J].1H(G,I):1n)}7 2.14(3(){6 K=C.i(2,E);5(H&&K&&C.3v(K[J])){K[J].1H(K,I)}o{5(!H){C.i(2,E,3e C[F][E](2,J))}}})};C[F][E]=3(I,H){6 G=2;2.15=E;2.2H=F+"-"+E;2.b=C.1A({},C.1i.1k,C[F][E].1k,H);2.c=C(I).u("1e."+E,3(L,J,K){7 G.1e(J,K)}).u("2j."+E,3(K,J){7 G.2j(J)}).u("W",3(){7 G.1b()});2.23()};C[F][E].1h=C.1A({},C.1i.1h,D)};C.1i.1h={23:3(){},1b:3(){2.c.1q(2.15)},2j:3(D){7 2.b[D]},1e:3(D,E){2.b[D]=E;5(D=="f"){2.c[E?"j":"r"](2.2H+"-f")}},1X:3(){2.1e("f",e)},1P:3(){2.1e("f",t)}};C.1i.1k={f:e};C.8.2J={3h:3(){6 D=2;2.c.u("3d."+2.15,3(E){7 D.2G(E)});5(C.x.13){2.2K=2.c.v("1p");2.c.v("1p","2I")}2.3c=e},38:3(){2.c.16("."+2.15);(C.x.13&&2.c.v("1p",2.2K))},2G:3(F){(2.V&&2.1o(F));2.1C=F;6 E=2,G=(F.39==1),D=(1F 2.b.25=="1E"?C(F.2f).2x().19(F.2f).y(2.b.25).k:e);5(!G||D||!2.2S(F)){7 t}2.1D=!2.b.26;5(!2.1D){2.3a=1x(3(){E.1D=t},2.b.26)}5(2.2m(F)&&2.1T(F)){2.V=(2.1U(F)!==e);5(!2.V){F.3b();7 t}}2.2n=3(H){7 E.2r(H)};2.2l=3(H){7 E.1o(H)};C(2N).u("2O."+2.15,2.2n).u("2t."+2.15,2.2l);7 e},2r:3(D){5(C.x.13&&!D.3j){7 2.1o(D)}5(2.V){2.1V(D);7 e}5(2.2m(D)&&2.1T(D)){2.V=(2.1U(2.1C,D)!==e);(2.V?2.1V(D):2.1o(D))}7!2.V},1o:3(D){C(2N).16("2O."+2.15,2.2n).16("2t."+2.15,2.2l);5(2.V){2.V=e;2.2u(D)}7 e},2m:3(D){7(29.3m(29.2z(2.1C.2L-D.2L),29.2z(2.1C.2s-D.2s))>=2.b.2F)},1T:3(D){7 2.1D},1U:3(D){},1V:3(D){},2u:3(D){},2S:3(D){7 t}};C.8.2J.1k={25:U,2F:1,26:0}})(27);(3(A){A.1i("8.4",{23:3(){2.b.Z+=".4";2.1m(t)},1e:3(B,C){5((/^d/).12(B)){2.1v(C)}o{2.b[B]=C;2.1m()}},k:3(){7 2.$4.k},1Q:3(B){7 B.2R&&B.2R.1g(/\\s/g,"2Q").1g(/[^A-4o-4x-9\\-2Q:\\.]/g,"")||2.b.2X+A.i(B)},8:3(C,B){7{b:2.b,4u:C,30:B,11:2.$4.11(C)}},1m:3(O){2.$l=A("1O:4p(a[p])",2.c);2.$4=2.$l.1G(3(){7 A("a",2)[0]});2.$h=A([]);6 P=2,D=2.b;2.$4.14(3(R,Q){5(Q.X&&Q.X.1g("#","")){P.$h=P.$h.19(Q.X)}o{5(A(Q).v("p")!="#"){A.i(Q,"p.4",Q.p);A.i(Q,"q.4",Q.p);6 T=P.1Q(Q);Q.p="#"+T;6 S=A("#"+T);5(!S.k){S=A(D.2d).v("1s",T).j(D.1u).4l(P.$h[R-1]||P.c);S.i("1b.4",t)}P.$h=P.$h.19(S)}o{D.f.28(R+1)}}});5(O){2.c.j(D.2b);2.$h.14(3(){6 Q=A(2);Q.j(D.1u)});5(D.d===1n){5(20.X){2.$4.14(3(S,Q){5(Q.X==20.X){D.d=S;5(A.x.13||A.x.43){6 R=A(20.X),T=R.v("1s");R.v("1s","");1x(3(){R.v("1s",T)},44)}4m(0,0);7 e}})}o{5(D.1c){6 J=46(A.1c("8-4"+A.i(P.c)),10);5(J&&P.$4[J]){D.d=J}}o{5(P.$l.y("."+D.m).k){D.d=P.$l.11(P.$l.y("."+D.m)[0])}}}}D.d=D.d===U||D.d!==1n?D.d:0;D.f=A.41(D.f.40(A.1G(2.$l.y("."+D.1a),3(R,Q){7 P.$l.11(R)}))).31();5(A.1j(D.d,D.f)!=-1){D.f.3V(A.1j(D.d,D.f),1)}2.$h.j(D.18);2.$l.r(D.m);5(D.d!==U){2.$h.w(D.d).1S().r(D.18);2.$l.w(D.d).j(D.m);6 K=3(){A(P.c).z("1K",[P.Y("1K"),P.8(P.$4[D.d],P.$h[D.d])],D.1S)};5(A.i(2.$4[D.d],"q.4")){2.q(D.d,K)}o{K()}}A(3U).u("3W",3(){P.$4.16(".4");P.$l=P.$4=P.$h=U})}21(6 G=0,N;N=2.$l[G];G++){A(N)[A.1j(G,D.f)!=-1&&!A(N).1f(D.m)?"j":"r"](D.1a)}5(D.17===e){2.$4.1q("17.4")}6 C,I,B={"3X-2E":0,1R:1},E="3Z";5(D.1d&&D.1d.3Y==2D){C=D.1d[0]||B,I=D.1d[1]||B}o{C=I=D.1d||B}6 H={1r:"",47:"",2T:""};5(!A.x.13){H.1W=""}3 M(R,Q,S){Q.2p(C,C.1R||E,3(){Q.j(D.18).n(H);5(A.x.13&&C.1W){Q[0].2B.y=""}5(S){L(R,S,Q)}})}3 L(R,S,Q){5(I===B){S.n("1r","1w")}S.2p(I,I.1R||E,3(){S.r(D.18).n(H);5(A.x.13&&I.1W){S[0].2B.y=""}A(P.c).z("1K",[P.Y("1K"),P.8(R,S[0])],D.1S)})}3 F(R,T,Q,S){T.j(D.m).4k().r(D.m);M(R,Q,S)}2.$4.16(".4").u(D.Z,3(){6 T=A(2).2x("1O:w(0)"),Q=P.$h.y(":4e"),S=A(2.X);5((T.1f(D.m)&&!D.1z)||T.1f(D.1a)||A(2).1f(D.1t)||A(P.c).z("2y",[P.Y("2y"),P.8(2,S[0])],D.1v)===e){2.1M();7 e}P.b.d=P.$4.11(2);5(D.1z){5(T.1f(D.m)){P.b.d=U;T.r(D.m);P.$h.1Y();M(2,Q);2.1M();7 e}o{5(!Q.k){P.$h.1Y();6 R=2;P.q(P.$4.11(2),3(){T.j(D.m).j(D.2c);L(R,S)});2.1M();7 e}}}5(D.1c){A.1c("8-4"+A.i(P.c),P.b.d,D.1c)}P.$h.1Y();5(S.k){6 R=2;P.q(P.$4.11(2),Q.k?3(){F(R,T,Q,S)}:3(){T.j(D.m);L(R,S)})}o{4b"27 4c 4d: 3n 49 4a."}5(A.x.13){2.1M()}7 e});5(!(/^24/).12(D.Z)){2.$4.u("24.4",3(){7 e})}},19:3(E,D,C){5(C==1n){C=2.$4.k}6 G=2.b;6 I=A(G.37.1g(/#\\{p\\}/g,E).1g(/#\\{1L\\}/g,D));I.i("1b.4",t);6 H=E.4i("#")==0?E.1g("#",""):2.1Q(A("a:4g-4h",I)[0]);6 F=A("#"+H);5(!F.k){F=A(G.2d).v("1s",H).j(G.18).i("1b.4",t)}F.j(G.1u);5(C>=2.$l.k){I.22(2.c);F.22(2.c[0].48)}o{I.36(2.$l[C]);F.36(2.$h[C])}G.f=A.1G(G.f,3(K,J){7 K>=C?++K:K});2.1m();5(2.$4.k==1){I.j(G.m);F.r(G.18);6 B=A.i(2.$4[0],"q.4");5(B){2.q(C,B)}}2.c.z("2Y",[2.Y("2Y"),2.8(2.$4[C],2.$h[C])],G.19)},W:3(B){6 D=2.b,E=2.$l.w(B).W(),C=2.$h.w(B).W();5(E.1f(D.m)&&2.$4.k>1){2.1v(B+(B+1<2.$4.k?1:-1))}D.f=A.1G(A.34(D.f,3(G,F){7 G!=B}),3(G,F){7 G>=B?--G:G});2.1m();2.c.z("2V",[2.Y("2V"),2.8(E.2k("a")[0],C[0])],D.W)},1X:3(B){6 C=2.b;5(A.1j(B,C.f)==-1){7}6 D=2.$l.w(B).r(C.1a);5(A.x.4n){D.n("1r","4t-1w");1x(3(){D.n("1r","1w")},0)}C.f=A.34(C.f,3(F,E){7 F!=B});2.c.z("33",[2.Y("33"),2.8(2.$4[B],2.$h[B])],C.1X)},1P:3(C){6 B=2,D=2.b;5(C!=D.d){2.$l.w(C).j(D.1a);D.f.28(C);D.f.31();2.c.z("32",[2.Y("32"),2.8(2.$4[C],2.$h[C])],D.1P)}},1v:3(B){5(1F B=="1E"){B=2.$4.11(2.$4.y("[p$="+B+"]")[0])}2.$4.w(B).4q(2.b.Z)},q:3(G,K){6 L=2,D=2.b,E=2.$4.w(G),J=E[0],H=K==1n||K===e,B=E.i("q.4");K=K||3(){};5(!B||!H&&A.i(J,"17.4")){K();7}6 M=3(N){6 O=A(N),P=O.2k("*:4s");7 P.k&&P.4v(":45(3R)")&&P||O};6 C=3(){L.$4.y("."+D.1t).r(D.1t).14(3(){5(D.1N){M(2).3l().1B(M(2).i("1L.4"))}});L.1y=U};5(D.1N){6 I=M(J).1B();M(J).3k("<2o></2o>").2k("2o").i("1L.4",I).1B(D.1N)}6 F=A.1A({},D.1J,{2U:B,2i:3(O,N){A(J.X).1B(O);C();5(D.17){A.i(J,"17.4",t)}A(L.c).z("2Z",[L.Y("2Z"),L.8(L.$4[G],L.$h[G])],D.q);D.1J.2i&&D.1J.2i(O,N);K()}});5(2.1y){2.1y.3f();C()}E.j(D.1t);1x(3(){L.1y=A.3u(F)},0)},2U:3(C,B){2.$4.w(C).1q("17.4").i("q.4",B)},1b:3(){6 B=2.b;2.c.16(".4").r(B.2b).1q("4");2.$4.14(3(){6 C=A.i(2,"p.4");5(C){2.p=C}6 D=A(2).16(".4");A.14(["p","q","17"],3(E,F){D.1q(F+".4")})});2.$l.19(2.$h).14(3(){5(A.i(2,"1b.4")){A(2).W()}o{A(2).r([B.m,B.2c,B.1a,B.1u,B.18].3G(" "))}})},Y:3(B){7 A.Z.3L({3t:B,2f:2.c[0]})}});A.8.4.1k={1z:e,Z:"24",f:[],1c:U,1N:"3F&#3A;",17:e,2X:"8-4-",1J:{},1d:U,37:\'<1O><a p="#{p}"><2W>#{1L}</2W></a></1O>\',2d:"<2a></2a>",2b:"8-4-3K",m:"8-4-d",2c:"8-4-1z",1a:"8-4-f",1u:"8-4-30",18:"8-4-3T",1t:"8-4-4w"};A.8.4.35="k";A.1A(A.8.4.1h,{1Z:U,4r:3(C,F){F=F||e;6 B=2,E=2.b.d;3 G(){B.1Z=42(3(){E=++E<B.$4.k?E:0;B.1v(E)},C)}3 D(H){5(!H||H.4j){4f(B.1Z)}}5(C){G();5(!F){2.$4.u(2.b.Z,D)}o{2.$4.u(2.b.Z,3(){D();E=B.b.d;G()})}}o{D();2.$4.16(2.b.Z,D)}}})})(27);', 62, 282, '||this|function|tabs|if|var|return|ui|||options|element|selected|false|disabled||panels|data|addClass|length|lis|selectedClass|css|else|href|load|removeClass||true|bind|attr|eq|browser|filter|triggerHandler|||||||||||||||||||||null|_mouseStarted|remove|hash|fakeEvent|event||index|test|msie|each|widgetName|unbind|cache|hideClass|add|disabledClass|destroy|cookie|fx|setData|hasClass|replace|prototype|widget|inArray|defaults|cssCache|tabify|undefined|mouseUp|unselectable|removeData|display|id|loadingClass|panelClass|select|block|setTimeout|xhr|unselect|extend|html|_mouseDownEvent|_mouseDelayMet|string|typeof|map|apply|plugins|ajaxOptions|tabsshow|label|blur|spinner|li|disable|tabId|duration|show|mouseDelayMet|mouseStart|mouseDrag|opacity|enable|stop|rotation|location|for|appendTo|init|click|cancel|delay|jQuery|push|Math|div|navClass|unselectClass|panelTemplate|fn|target|top|split|success|getData|find|_mouseUpDelegate|mouseDistanceMet|_mouseMoveDelegate|em|animate|MozUserSelect|mouseMove|pageY|mouseup|mouseStop|none|get|parents|tabsselect|abs|5000px|style|body|Array|width|distance|mouseDown|widgetBaseClass|on|mouse|_mouseUnselectable|pageX|arguments|document|mousemove|call|_|title|mouseCapture|height|url|tabsremove|span|idPrefix|tabsadd|tabsload|panel|sort|tabsdisable|tabsenable|grep|getter|insertBefore|tabTemplate|mouseDestroy|which|_mouseDelayTimer|preventDefault|started|mousedown|new|abort|left|mouseInit|absolute|button|wrapInner|parent|max|Mismatching|plugin|in|position|gen|class|type|ajax|isFunction|backgroundImage|catch|disableSelection|cursor|8230|removeChild|rgba|backgroundColor|try|Loading|join|enableSelection|auto|slice|nav|fix|scrollLeft|scrollTop|off|default|hasScroll|img|transparent|hide|window|splice|unload|min|constructor|normal|concat|unique|setInterval|opera|500|not|parseInt|overflow|parentNode|fragment|identifier|throw|UI|Tabs|visible|clearInterval|first|child|indexOf|clientX|siblings|insertAfter|scrollTo|safari|Za|has|trigger|rotate|last|inline|tab|is|loading|z0'.split('|'), 0, {}))

//END jquery.ui-personalized-1.5.2.packed.js for menu @@@@@@@@@@

$(document).ready(function() {
    $('.tabvanilla > ul').tabs({ fx: { opacity: 'toggle'} });
    //$('#tabvanilla > ul').tabs();
});


//START jquery.bxcarousel-mini.js for tab scoll @@@@@@@@@@
/*
bxCarousel v1.0
Plugin developed by: Steven Wanderski
http://bxcarousel.com
http://stevenwanderski.com

Released under the GPL license:
http://www.gnu.org/licenses/gpl.html
*/


/*You can Change Speed and interval of image rotation*/
(function($) {
    $.fn.bxCarousel = function(options) {
        var defaults = { move: 2, display_num: 2, speed: 0, margin: 0, auto: false, auto_interval: 0, auto_dir: 'next', auto_hover: false, next_text: 'next', next_image: '', prev_text: 'prev', prev_image: '', controls: true }; var options = $.extend(defaults, options); return this.each(function() {
            var $this = $(this); var li = $this.find('li'); var first = 0; var fe = 0; var last = options.display_num - 1; var le = options.display_num - 1; var is_working = false; var j = ''; var clicked = false; li.css({ 'float': 'left', 'listStyle': 'none', 'marginRight': options.margin }); var ow = li.outerWidth(true); wrap_width = (ow * options.display_num) - options.margin; var seg = ow * options.move; $this.wrap('<div class="bx_container"></div>').width(999999); if (options.controls) {
                if (options.next_image != '' || options.prev_image != '') { var controls = '<a href="" class="prev"><img src="' + options.prev_image + '"/></a><a href="" class="next"><img src="' + options.next_image + '"/></a>'; }
                else { var controls = '<a href="" class="prev">' + options.prev_text + '</a><a href="" class="next">' + options.next_text + '</a>'; } 
            }
            $this.parent('.bx_container').wrap('<div class="bx_wrap"></div>').css({ 'position': 'relative', 'width': wrap_width, 'overflow': 'hidden' }).before(controls); var w = li.slice(0, options.display_num).clone(); var last_appended = (options.display_num + options.move) - 1; $this.empty().append(w); get_p(); get_a(); $this.css({ 'position': 'relative', 'left': -(seg) }); $this.parent().siblings('.next').click(function() { slide_next(); clearInterval(j); clicked = true; return false; }); $this.parent().siblings('.prev').click(function() { slide_prev(); clearInterval(j); clicked = true; return false; }); if (options.auto) { start_slide(); if (options.auto_hover && clicked != true) { $this.find('li').live('mouseenter', function() { if (!clicked) { clearInterval(j); } }); $this.find('li').live('mouseleave', function() { if (!clicked) { start_slide(); } }); } }
            function start_slide() { if (options.auto_dir == 'next') { j = setInterval(function() { slide_next() }, options.auto_interval); } else { j = setInterval(function() { slide_prev() }, options.auto_interval); } }
            function slide_next() { if (!is_working) { is_working = true; set_pos('next'); $this.animate({ left: '-=' + seg }, options.speed, function() { $this.find('li').slice(0, options.move).remove(); $this.css('left', -(seg)); get_a(); is_working = false; }); } }
            function slide_prev() { if (!is_working) { is_working = true; set_pos('prev'); $this.animate({ left: '+=' + seg }, options.speed, function() { $this.find('li').slice(-options.move).remove(); $this.css('left', -(seg)); get_p(); is_working = false; }); } }
            function get_a() {
                var str = new Array(); var lix = li.clone(); le = last; for (i = 0; i < options.move; i++) {
                    le++
                    if (lix[le] != undefined) { str[i] = $(lix[le]); } else { le = 0; str[i] = $(lix[le]); } 
                }
                $.each(str, function(index) { $this.append(str[index][0]); });
            }
            function get_p() {
                var str = new Array(); var lix = li.clone(); fe = first; for (i = 0; i < options.move; i++) {
                    fe--
                    if (lix[fe] != undefined) { str[i] = $(lix[fe]); } else { fe = li.length - 1; str[i] = $(lix[fe]); } 
                }
                $.each(str, function(index) { $this.prepend(str[index][0]); });
            }
            function set_pos(dir) {
                if (dir == 'next') {
                    first += options.move; if (first >= li.length) { first = first % li.length; }
                    last += options.move; if (last >= li.length) { last = last % li.length; } 
                } else if (dir == 'prev') {
                    first -= options.move; if (first < 0) { first = li.length + first; }
                    last -= options.move; if (last < 0) { last = li.length + last; } 
                } 
            } 
        });
    } 
})(jQuery);


$('#example1').ready(function() {
    $('#example1').bxCarousel({
        display_num: 2,
        move: 1,
        auto: false,
        prev_image: 'images/arrow-lt.gif',
        next_image: 'images/arrow-rt.gif',
        margin: 0,
        border: 0,
        auto_hover: false
    });
});

//END jquery.bxcarousel.js for tab scoll @@@@@@@@@@