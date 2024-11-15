document.querySelectorAll(".available").forEach((button) => {
    button.addEventListener("click", function () {
        document
            .querySelector(".btn-selected")
            ?.classList.remove("btn-selected");
        this.classList.add("btn-selected");
        document.getElementById("final-table").value =
            this.getAttribute("data-table");
        document.getElementById(
            "status-message"
        ).innerText = `Bạn đã chọn bàn ${this.getAttribute("data-table")}`;
    });
});

document.getElementById("continue-to-menu").addEventListener("click", () => {
    if (!document.getElementById("final-table").value) {
        alert("Vui lòng chọn bàn.");
    } else {
        document.getElementById("step-1").style.display = "none";
        document.getElementById("step-2").style.display = "block";
        document.getElementById("status-message").innerText =
            "Vui lòng chọn thực đơn.";
    }
});

document.getElementById("menu-dropdown").addEventListener("click", () => {
    const options = document.getElementById("dropdown-options");
    options.style.display =
        options.style.display === "block" ? "none" : "block";
});

document.querySelectorAll(".dropdown-option").forEach((option) => {
    option.addEventListener("click", function () {
        const selectedValue = this.getAttribute("data-value");
        const selectedSrc = this.getAttribute("data-src");
        document.getElementById("selected-menu").value = selectedValue;
        document
            .getElementById("menu-dropdown")
            .querySelector("span").textContent = this.textContent;
        document.getElementById("selected-menu-image").src = selectedSrc;
        document.getElementById("selected-menu-image").style.display = "block";
        document.getElementById("dropdown-options").style.display = "none";
    });
});

document.getElementById("continue-to-details").addEventListener("click", () => {
    document.getElementById("step-2").style.display = "none";
    document.getElementById("step-3").style.display = "block";
    document.getElementById("status-message").innerText =
        "Vui lòng nhập thông tin của bạn để xác nhận đặt bàn.";
});
