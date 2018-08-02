var consensus = consensus || {};
consensus.web = consensus.web || {};

consensus.web.addressField = function (addressId, address1, address2, address3, town, county, postcode, country, orgId) {
	var closure = this;
	this.opening = false;
	this._orgId = orgId;
	this._addressId = $('#' + addressId + ' input');
	this._address1 = $('#' + address1 + ' input');
	this._address2 = $('#' + address2 + ' input');
	this._address3 = $('#' + address3 + ' input');
	this._town = $('#' + town + ' input');
	this._county = $('#' + county + ' input');
	this._postcode = $('#' + postcode + ' input');
	this._country = $('#' + country + ' select');
	this._updateIcon = function (icon) {
		closure._address1.next('.input-group-addon').find('.glyphicon')
          .removeClass(function (index, className) {
          	return (className.match(/(^|\s)glyphicon-\S+/g) || []).join(' ');
          }).addClass(icon);
	};
	this.lockFields = function (orgId, addressId, addressLine1, addressLine2, addressLine3, town, county, postcode, country) {
		this._orgId = orgId;
		this._addressId.val(addressId);
		this._address1.val(addressLine1).attr('readonly', 'readonly');
		this._address2.val(addressLine2).attr('readonly', 'readonly');
		this._address3.val(addressLine3).attr('readonly', 'readonly');
		this._town.val(town).attr('readonly', 'readonly');
		this._county.val(county).attr('readonly', 'readonly');
		this._postcode.val(postcode).attr('readonly', 'readonly');
		this._country.val(country).attr('readonly', 'readonly');
	};
	this.unlockFields = function () {
		this._orgId = null;
		this._addressId.val('');
		this._address1.val('').attr('readonly', null);
		this._address2.val('').attr('readonly', null);
		this._address3.val('').attr('readonly', null);
		this._town.val('').attr('readonly', null);
		this._county.val('').attr('readonly', null);
		this._postcode.val('').attr('readonly', null);
		this._country.val('').attr('readonly', null);
	};
	this.openPopup = function () {
		if (closure._orgId) {
			closure._opening = true;
			closure._updateIcon('glyphicon-repeat glyphicon-spin');
			consensus.web.popupFrame({
				url: consensus.resolveUrl('~/genericpopup.aspx?context=crm&control=addresslist&type=altbutton&width=1200&select=1&orgId=' + closure._orgId),
				open: function () {
					closure._updateIcon('glyphicon-search');
					closure._opening = false;
				},
				result: function (result) {
					closure.lockFields(closure._orgId, result.data.id, result.data.Building, result.data.Street, result.data.Area, result.data.Town, result.data.County, result.data.Postcode, result.data.Country);
				}
			});
		} else {
			window.top.swal.call(window.top, { title: 'Warning', text: 'You have not selected an organisation.', type: 'warning', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-danger', buttonsStyling: false }).then(function (success) {
			});
		}

	};
	this._address1.next('.input-group-addon').on('click', function () {
		if (!closure._opening)
			closure.openPopup();
	});
};