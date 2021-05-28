using AutoMapper;
using IntroductionToAspMVC.Models;
using IntroductionToAspMVC.Services;
using IntroductionToAspMVC.ViewModels;
using IntroductionToAspMVC.ViewModels.Contacts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _service;
        private readonly IMapper _mapper;

        public ContactController(IContactService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            ICollection<Contact> contacts = await _service.GetContactsAsync();
            var viewModel = new ContactViewModel
            {
                Contacts = _mapper.Map<ICollection<Contact>>(contacts)
            };
            return View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            Contact contact = await _service.GetContactAsync(id);
            ContactDetailViewModel vm = _mapper.Map<ContactDetailViewModel>(contact);
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ContactAddViewModel vm)
        {
            bool isValid = TryValidateModel(vm);
            if (isValid)
            {
                Contact contact = _mapper.Map<Contact>(vm);
                _service.AddContactAsync(contact);
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Contact contact = await _service.GetContactAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            ContactDeleteViewModel vm = _mapper.Map<ContactDeleteViewModel>(contact);
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ContactDeleteViewModel vm)
        {
            if (vm == null)
            {
                return NotFound();
            }
            Contact model = _mapper.Map<Contact>(vm);
            await _service.DeleteContactAsync(model);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Contact contact = await _service.GetContactAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            ContactUpdateViewModel vm = _mapper.Map<ContactUpdateViewModel>(contact);
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ContactUpdateViewModel vm)
        {
            bool isValid = TryValidateModel(vm);
            if (!isValid)
            {
                return View(vm);
            }
            Contact model = _mapper.Map<Contact>(vm);
            await _service.UpdateContactAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}