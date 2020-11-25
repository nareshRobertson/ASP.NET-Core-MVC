// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {

	$('#deleteModal').on('show.bs.modal', function (event) {
		var button = $(event.relatedTarget) // Button that triggered the modal
		var itemName = button.data('name') // Extract info from data-* attributes
		var modal = $(this)
		modal.find('.modal-body').text('Are you sure you want to delete ' + itemName + '?')
	});

	// Every time we press delete in the table row
	$('.delete').click(function () {
		// Update the item to delete id so our model knows which one to delete
		var id = $(this).data('id');
		$('#item-to-delete').val(id);
	});

	// Everytime we press sumbit on the modal form...
	$('#confirm-delete').click(function (event) {
		var element = $(event.target) // Item that triggered the event
		var controller = element.data('controller')
		var goto = controller + "/Delete"

		//Get the id to delete from the hidden field
		var id = $('#item-to-delete').val();

		//Call our delete method and pass over this id
		$.post(goto, { id: id }, function () {
			location.reload();
		});
	});

	$('#dropModal').on('show.bs.modal', function (event) {
		var button = $(event.relatedTarget) // Button that triggered the modal
		var itemName = button.data('name') // Extract info from data-* attributes
		var modal = $(this)
		modal.find('.modal-body').text('Are you sure you want to drop ' + itemName + '?')
	});

	// Every time we press delete in the table row
	$('.drop').click(function () {
		// Update the item to delete id so our model knows which one to delete
		var id = $(this).data('id');
		$('#item-to-drop').val(id);
	});

	// Every time we press sumbit on the drop course modal...
	$('#confirm-drop').click(function (event) {
		var element = $(event.target) // Item that triggered the event
		var controller = element.data('controller')
		var goto = controller + "/Drop"

		//Get the id to delete from the hidden field
		var id = $('#item-to-drop').val();

		//Call our delete method and pass over this id
		$.post("/Edit/Drop", { id: id }, function () {
			location.reload();
		});
	});
});