

window.ShowToastr = (type, message) => {

    toastr.options.toastClass = "toastr";

    if (type === "success") {
        toastr.success(message, "Success", { timeOut: 2000 });
    }
    else if (type === "error") {
        toastr.error(message, "Error", { timeOut: 4000 });
    }
    else if (type === "info") {
        toastr.info(message, "Information", { timeOut: 4000 });
    }
    else {
        toastr.warning(message, "Warning", { timeOut: 4000 });
    }
}

window.CloseModal = (modalId) => {
    $(modalId).removeClass("show");
    $(modalId).removeAttr("aria-modal");
    $(modalId).removeAttr("role");
    $(modalId).removeAttr("style");
    $(modalId).attr("aria-hidden", true);
    $(modalId).attr("style", "display:none;");

    $('body').removeClass("modal-open");
    $('body').removeAttr("style");

    $(".modal-backdrop").remove();
}
