from r in
(from r in db.Rounds
select new {
  r.Points,
  Dummy = "x"
})
group r by new { r.Dummy } into g
select new {
  Column1 = (double?)g.Average(p => p.Points)
}